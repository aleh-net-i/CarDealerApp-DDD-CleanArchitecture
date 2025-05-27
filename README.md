# 🚗 Car Dealer DDD - Clean Architecture

[![.NET](https://img.shields.io/badge/.NET-9.0-blue.svg)](https://dotnet.microsoft.com/download/dotnet/9.0)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Build Status](https://img.shields.io/badge/build-passing-brightgreen.svg)]()
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)]()

A comprehensive **Car Dealership Management System** built with **Clean Architecture**, **Domain-Driven Design (DDD)**, and **CQRS** patterns using **ASP.NET Core 9**.

## 🏗️ Architecture Overview

```
┌─────────────────────────────────────────────────┐
│                 Presentation                    │
│              (Controllers, Views)               │
├─────────────────────────────────────────────────┤
│                  Application                    │
│         (Use Cases, Commands, Queries)          │
├─────────────────────────────────────────────────┤
│                 Infrastructure                  │
│        (Data Access, External Services)         │
├─────────────────────────────────────────────────┤
│                    Domain                       │
│        (Entities, Value Objects, Rules)         │
└─────────────────────────────────────────────────┘
```

## ✨ Key Features

### 🎯 **Domain-Driven Design**
- ✅ Rich domain models with business logic
- ✅ Value objects (VIN, Money, DateRange)
- ✅ Domain services and specifications
- ✅ Domain events for cross-cutting concerns

### 🏛️ **Clean Architecture**
- ✅ Clear separation of concerns
- ✅ Dependency inversion principle
- ✅ Testable and maintainable code
- ✅ Framework-independent domain layer

### ⚡ **CQRS & Mediator Pattern**
- ✅ Commands for write operations
- ✅ Queries for read operations
- ✅ MediatR for request/response handling
- ✅ Validation pipeline with FluentValidation

### 🔐 **Enterprise Features**
- ✅ User authentication & authorization
- ✅ File upload/download management
- ✅ Excel/PDF/CSV export capabilities
- ✅ Advanced search and pagination
- ✅ Responsive Bootstrap UI
- ✅ Comprehensive validation

## 🚀 Quick Start

### Prerequisites
- .NET 9 SDK
- SQL Server or SQL Server LocalDB
- Visual Studio 2022 or VS Code

### Setup
```bash
# Clone the repository
git clone https://github.com/aleh-net-i/CarDealerApp-DDD-CleanArchitecture.git
cd CarDealerApp-DDD-CleanArchitecture

# Run automated setup
.\scripts\setup-dev.ps1

# Build and run
.\scripts\build.ps1
dotnet run --project src/Presentation/CarDealerApp.Web
```

### Default Admin Account
- **Email**: `administrator@cardealer.com`
- **Password**: `Administrator1!`

## 📁 Project Structure

```
src/
├── Core/                          # Domain & Application layers
│   ├── CarDealerApp.Do