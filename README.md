# 🖥️ WPF Mastery Path

> A structured, hands-on learning journey through **Windows Presentation Foundation (WPF)** — from fundamentals to advanced patterns — using C# and .NET.

---

## 📌 Overview

**WPF Mastery Path** is a progressive, bootcamp-style repository designed to help developers build real-world desktop applications with WPF. Each bootcamp module focuses on a specific area of WPF, gradually building your knowledge from core UI concepts to professional-grade architectural patterns.

Whether you're a C# developer stepping into desktop development or looking to sharpen your WPF skills, this path provides structured, practical code examples.

---

## 📁 Repository Structure

```
WPF-Mastery-Path/
│
└── WPF.BootCamps/          # Modular bootcamp projects, each targeting a WPF topic
│
└── YourApp.ProjectArchitecture/
│
└── OrderManagementSystem(MiniProject)/
```

---

## 🗺️ Learning Path

The bootcamps are organized progressively. Below is the intended learning order:

| # | Module | Topics Covered |
|---|--------|---------------|
| 01 | **WPF Fundamentals** | XAML syntax, Window, Grid, StackPanel, basic controls |
| 02 | **Layout & Panels** | Canvas, DockPanel, WrapPanel, responsive layouts |
| 03 | **Data Binding** | One-way, two-way, source/target binding, binding context |
| 04 | **MVVM Pattern** | ViewModel, INotifyPropertyChanged, commands, separation of concerns |
| 05 | **Styles & Templates** | ControlTemplate, DataTemplate, triggers, resource dictionaries |
| 06 | **Commands & Interactions** | ICommand, RelayCommand, routed commands, input handling |
| 07 | **Collections & Lists** | ObservableCollection, ItemsControl, ListView, DataGrid |
| 08 | **Navigation** | Frame-based navigation, multi-page apps, region navigation |
| 09 | **Animations** | Storyboards, transitions, visual states, smooth UX |
| 10 | **Advanced Topics** | Custom controls, attached properties, behaviors, dependency properties |

> ⚠️ *Modules are added incrementally. Check back for new bootcamps as the repo grows.*

---

## 🚀 Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (6.0 or later recommended)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (Community edition is free)
  - Workload required: **.NET desktop development**
- Windows OS (WPF is Windows-only)

### Clone the Repository

```bash
git clone https://github.com/khzl/WPF-Mastery-Path.git
cd WPF-Mastery-Path
```

### Run a Bootcamp Project

1. Open Visual Studio
2. Navigate to `WPF.BootCamps/`
3. Open the `.sln` file of the module you want to explore
4. Press `F5` to build and run

---

## 🛠️ Tech Stack

| Technology | Details |
|------------|---------|
| **Language** | C# |
| **Framework** | .NET (WPF) |
| **UI Layer** | XAML |
| **IDE** | Visual Studio 2022 |
| **Pattern** | MVVM |

---

## 🧠 Key WPF Concepts Covered

- **XAML** — Declarative UI markup language for building interfaces
- **Data Binding** — Linking UI controls to data sources automatically
- **MVVM** — Model-View-ViewModel architecture for clean, testable code
- **Dependency Properties** — WPF's powerful property system for binding and styling
- **Control & Data Templates** — Customizing the look and feel of any control
- **Routed Events** — WPF's bubbling/tunneling event system
- **Resource Dictionaries** — Centralized styles, brushes, and templates

---

## 🤝 Contributing

Contributions are welcome! If you'd like to add a new bootcamp, fix a bug, or improve existing examples:

1. Fork the repository
2. Create a new branch: `git checkout -b feature/your-topic`
3. Commit your changes: `git commit -m "Add: new bootcamp on [topic]"`
4. Push to your branch: `git push origin feature/your-topic`
5. Open a Pull Request

Please keep each bootcamp focused on a single topic and include a brief comment at the top of each project explaining what it demonstrates.

---

## 📄 License

This project is open-source and available under the [MIT License](LICENSE).

---

## 👤 Author

**khzl**  
GitHub: [@khzl](https://github.com/khzl)

---

<div align="center">
  <sub>Built with ❤️ to make WPF learning structured and approachable.</sub>
</div>
