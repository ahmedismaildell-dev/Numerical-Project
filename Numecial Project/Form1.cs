using Numarical_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Logic_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private  enum MethodType
        {
            Bisection,
            FalsePosition,
            FixedPoint,
            Newton,
            Secant
        }
        private double? _Xl = null;
        private double? _Xu = null;
        private double? _X0 = null;
        private double? _ε = null;
        private double _Root;


        private MethodType _methodType;

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtAreaName_TextChanged(object sender, EventArgs e)
        {

        }
        private void _RestartDefault()
        {
            txtFunction.Text = "";
            txtX0.Text = "";
            txtXl.Text = "";
            txtXu.Text = "";
            txtError.Text = "";
            dgvIterationDetials.DataSource = null;
            lblRoot.Text = "???";

        }
        private void InitializecbMethodType()
        {
            cbMethodType.DataSource = Enum.GetValues(typeof(MethodType));
            cbMethodType.SelectedIndex = -1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializecbMethodType();

        }
        private void InitializecbMethodParameter()
        {
            lblXl.Text = "Xl";
            lblXu.Text = "Xu";
            switch (_methodType)
            {
                case MethodType.Bisection:
                    {
                        txtXl.Enabled = true;
                        txtXu.Enabled = true;
                        txtX0.Enabled = false;
                        break;
                    }
                case MethodType.FalsePosition:
                    {
                        txtXl.Enabled = true;
                        txtXu.Enabled = true;
                        txtX0.Enabled = false;
                        break;

                    }
                case MethodType.FixedPoint:
                    {
                        txtXl.Enabled = false;
                        txtXu.Enabled = false;
                        txtX0.Enabled = true;
                        break;

                    }
                case MethodType.Newton:
                    {
                        txtXl.Enabled = false;
                        txtXu.Enabled = false;
                        txtX0.Enabled = true;
                        break;


                    }
                case MethodType.Secant:
                    {
                        lblXl.Text = "Xi-1";
                        lblXu.Text = "Xi";
                        txtXl.Enabled = true;
                        txtXu.Enabled = true;
                        txtX0.Enabled = false;
                        break;

                    }
            }
        }
        private double? TryGetDouble(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return null;

            if (double.TryParse(input, out double value))
                return value;

            throw new Exception("Invalid number format");
        }
        private void ReadValuesFromInput()
        {
            _Xl = TryGetDouble(txtXl.Text);
            _Xu = TryGetDouble(txtXu.Text);
            _X0 = TryGetDouble(txtX0.Text);
            _ε= TryGetDouble(txtError.Text);
        }
        private void Rename(string columnName, string header)
        {
            if (dgvIterationDetials.Columns.Contains(columnName))
                dgvIterationDetials.Columns[columnName].HeaderText = header;
        }
        private void OrderColumns(params string[] order)
        {
            for (int i = 0; i < order.Length; i++)
            {
                if (dgvIterationDetials.Columns.Contains(order[i]))
                    dgvIterationDetials.Columns[order[i]].DisplayIndex = i;
            }
        }
        private void SetupGrid(MethodType methodType)
        {
            dgvIterationDetials.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIterationDetials.RowHeadersVisible = false;
            dgvIterationDetials.AllowUserToAddRows = false;

            dgvIterationDetials.CellFormatting += (s, e) =>
            {
                if (e.Value is double d)
                    e.Value = d.ToString("F3");
            };

            foreach (DataGridViewColumn col in dgvIterationDetials.Columns)
                col.HeaderText = col.Name;

            switch (methodType)
            {
                case MethodType.Bisection:
                case MethodType.FalsePosition:

                    Rename("Xl", "Xl");
                    Rename("FXl", "f(Xl)");
                    Rename("Xu", "Xu");
                    Rename("FXu", "f(Xu)");
                    Rename("Xr", "Xr");
                    Rename("FXr", "f(Xr)");
                    Rename("Error", "Error %");

                    break;

                case MethodType.FixedPoint:

                    Rename("Xi", "Xi");
                    Rename("FXi", "f(Xi)");
                    Rename("Error", "Error %");

                    break;

                case MethodType.Newton:

                    Rename("Xi", "Xi");
                    Rename("FXi", "f(Xi)");
                    Rename("FDashXi", "f'(Xi)");
                    Rename("Error", "Error %");

                    break;

                case MethodType.Secant:

                    Rename("XiMinus1", "Xi-1");
                    Rename("FXiMinus1", "f(Xi-1)");
                    Rename("Xi", "Xi");
                    Rename("FXi", "f(Xi)");
                    Rename("Error", "Error %");

                    break;
            }
            dgvIterationDetials.ColumnHeadersHeightSizeMode =
      DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }
        private void _SolveToMethodType(Func<double, double> f )
        {
            ReadValuesFromInput();

            if (f == null)
            {
                MessageBox.Show("Function is null");
                return;
            }

            if (_methodType == null)
            {
                MessageBox.Show("Please select method");
                return;
            }
            switch (_methodType)
            {
                case MethodType.Bisection:
                    {
                        var res = clsMethods.Bisection(f, _Xl.Value, _Xu.Value, _ε.Value);
                        dgvIterationDetials.DataSource = null;

                        
                        dgvIterationDetials.DataSource = res;

                        SetupGrid(MethodType.Bisection);

                        OrderColumns("Iteration", "Xl", "FXl", "Xu", "FXu", "Xr", "FXr", "Error");

                        lblRoot.Text = res.Last().Xr.ToString("F6");
                        break;
                    }

                case MethodType.FalsePosition:
                    {
                        var res = clsMethods.FalsePosition(f, _Xl.Value, _Xu.Value, _ε.Value);
                        dgvIterationDetials.AutoGenerateColumns = true;   // ✅ مهم جدًا

                        dgvIterationDetials.DataSource = res;

                        SetupGrid(MethodType.FalsePosition);

                        OrderColumns("Iteration", "Xl", "FXl", "Xu", "FXu", "Xr", "FXr", "Error");

                        lblRoot.Text = res.Last().Xr.ToString("F6");
                        break;
                    }

                case MethodType.FixedPoint:
                    {
                        var res = clsMethods.FixedPointAuto(f, _X0.Value, _ε.Value);

                        dgvIterationDetials.DataSource = res;

                        SetupGrid(MethodType.FixedPoint);

                        OrderColumns("Iteration", "Xi", "XiPlus1", "Error");

                        lblRoot.Text = res.Last().FXi.ToString("F6");
                        break;
                    }

                case MethodType.Newton:
                    {
                        var res = clsMethods.Newton(f, _X0.Value, _ε.Value);

                        dgvIterationDetials.DataSource = res;

                        SetupGrid(MethodType.Newton);

                        OrderColumns("Iteration", "Xi", "FXi", "FDashXi", "Error");

                        lblRoot.Text = res.Last().Xi.ToString("F6");
                        break;
                    }

                case MethodType.Secant:
                    {
                        var res = clsMethods.Secant(f, _Xl.Value, _Xu.Value, _ε.Value);

                        dgvIterationDetials.DataSource = res;

                        SetupGrid(MethodType.Secant);

                        OrderColumns("Iteration", "XiMinus1", "FXiMinus1", "Xi", "FXi", "Error");

                        lblRoot.Text = res.Last().Xi.ToString("F6");
                        break;
                    }
            }
        }
            

        private void cbMethodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMethodType.SelectedIndex == -1)
                return;
            _methodType = (MethodType)cbMethodType.SelectedItem;

            InitializecbMethodParameter();
            _RestartDefault();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            string exprStr = txtFunction.Text.Trim();

            // ✅ validation
            if (string.IsNullOrWhiteSpace(exprStr))
            {
                MessageBox.Show("Please enter a function");
                return;
            }

            try
            {
                FunctionEvaluator functionEvaluator = new FunctionEvaluator(exprStr);

               _SolveToMethodType(functionEvaluator.Evaluate);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
