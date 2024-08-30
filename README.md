# CampaignBudgetCalculator

This is a simple web-based application for optimizing ad spend in a campaign. The application calculates the optimal budget allocation for a specific ad while ensuring the total campaign budget remains within the approved amount.

## Features

- Calculate optimal ad spend using a Goal Seek algorithm.
- Input total campaign budget, individual ad budgets, agency fees, third-party tool fees, and fixed costs.

## Prerequisites

- [.NET 6.0 SDK or higher](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/)

## Getting Started

### 1. Clone the Repository

Clone this repository to your local machine using the following command:

```bash
git clone https://github.com/vishalkanteppa/CampaignBudgetCalculator.git
```

### 2. Navigate to the Project Directory

```bash
cd CampaignBudgetCalculator
```

### 3. Open the Project in Visual Studio

- Double-click the `.sln` file to open the project.

### 4. Build the Project

Ensure that all dependencies are installed, then build the project:

- Use `Ctrl + Shift + B` to build the solution.
- 

### 5. Run the Application

- Press `F5` to run the application with debugging, or `Ctrl + F5` to run without debugging.


### 6. Access the Application

Once the application is running, open your web browser and go to:

```
https://localhost:5001/campaign
```

Now you can input the total campaign budget, individual ad budgets, agency fees, third-party tool fees, and fixed costs to calculate the optimal ad budget.
