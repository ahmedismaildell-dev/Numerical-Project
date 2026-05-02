# Numerical Methods Solver (WinForms)

## 📌 Overview

A Windows Forms application built with C# to solve nonlinear equations using classical numerical methods.
Users can input any mathematical expression and observe step-by-step iterations, errors, and final root.

---

## 🚀 Features

* Bisection Method

* False Position (Regula Falsi)

* Fixed Point Method (auto g(x) generation for quadratic)

* Newton-Raphson Method (numerical derivative)

* Secant Method

* Dynamic function input (via NCalc)

* Iteration table with:

  * Intermediate values
  * Function evaluations
  * Relative error (%)

* Final root display with precision

---

## 🧠 Architecture

### 🔹 Business Layer (`Numarical_Business`)

Contains all numerical algorithms and helpers:

* `clsMethods` → Implements all solving methods
* `clsHelper` → Numerical derivative + helper utilities
* `FunctionEvaluator` → Parses and evaluates user expressions
* Models → Result objects (Bisection, Newton, Secant, etc.)

### 🔹 UI Layer (`Logic_project`)

* Built with Windows Forms
* Handles user input, validation, and visualization
* Displays results using `DataGridView`

---

## ▶️ How to Run

### 🔹 Option 1 (Recommended)

Clone the repository:

```bash
git clone <your-repo-link>
```

---

### 🔹 Option 2 (Download ZIP)

If you download as ZIP, run:

```powershell
Get-ChildItem -Recurse | Unblock-File
```

Then open the solution in Visual Studio.

---

## ⚙️ Requirements

* Visual Studio 2019/2022
* .NET Framework / .NET
* NuGet package:

  * `NCalc`

---

## ⚠️ Important Notes

* Set **Logic_project (WinForms)** as Startup Project
* If you see:

  > Class Library cannot be started directly
  > → You selected the wrong project

---

## 📊 Supported Function Input

You can write expressions like:

* `x^3 - 4*x + 1`
* `sin(x) + x^2`
* `exp(x) - 3`

---

## 🛠️ Technologies

* C#
* Windows Forms
* .NET
* NCalc
* OOP Design

---

## 📸 Screenshots

<img width="1166" height="779" alt="image" src="https://github.com/user-attachments/assets/2424eee5-e700-4425-b993-88331e1e1536" />

---

## 👨‍💻 Author

Ahmed Ismail

---

## ⭐ Future Improvements

* Graph plotting (function + root)
* Export results to CSV/Excel
* Better validation & UX
* Support symbolic derivative
