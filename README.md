# Copilot Skills & Prompts Files Training
## Visual Studio 2026 + Azure DevOps Environment

---

## Training Overview

| **Duration** | 90 minutes (initial training) |
|--------------|-------------------------------|
| **Audience** | Junior developers new to AI coding assistants |
| **Prerequisites** | Basic C# knowledge, VS 2026 installed, Copilot license active, completed Testing Fundamentals session |
| **Format** | Instructor-led with hands-on exercises |
| **Materials** | Sample Visual Studio solution provided |

---

## Agenda

### Module 1: Foundations & Core Concepts (15 min)
- Level setting: Key terminology
  - What is a prompt and how AI perceives intent
  - Core terms: prompts, context, skills, instructions, agents
- Standard use phrases for guiding AI behavior
- **Exercise 1:** First interaction with Copilot Chat

### Module 2: Multi-Phase Planning & Complex Tasks (15 min)
- Why single-prompt approaches fail for complex work
- The plan-execute-summarize workflow
- **Exercise 2:** Create a phased implementation plan
- **Exercise 3:** Execute phase one with guided prompts

### Module 3: Prompts Files & Project Instructions (15 min)
- Understanding prompts files and their purpose
- Solution-wide vs. project-specific instructions
- **Exercise 4:** Create and test a prompts file
- **Exercise 5:** Compare AI behavior with and without instructions

### Module 4: Reusable Custom Prompts (15 min)
- Creating prompt templates for common tasks
- Storing and sharing prompts across your team
- **Exercise 6:** Build a custom prompt library
- **Exercise 7:** Apply reusable prompts to real scenarios

### Module 5: Copilot Agents (15 min)
- What are agents and when to use them
- Built-in agents in VS 2026
- Combining agents with custom prompts
- **Exercise 8:** Working with workspace and code agents
- **Exercise 9:** Agent-assisted refactoring

### Module 6: Custom Skills Library (12 min)
- Building organization-specific skills
- Registering and sharing custom skills
- **Exercise 10:** Create and use a custom skill

### Module 7: Putting It All Together (3 min)
- Complete workflow recap
- Key takeaways and action items

---

**Total Time: ~90 minutes**
**Hands-on Time: ~50 minutes**

---

## Pre-Training Setup

### Sample Solution Structure

Clone this repository and open the following solution open the `CopilotTraining.sln` solution in Visual Studio 2026:

```
📁 CopilotTraining/
├── 📁 .github/
│   └── 📁 copilot/
│       └── 📁 prompts/           ← Reusable prompt templates
├── 📁 src/
│   ├── 📁 CopilotTraining.Domain/
│   │   ├── 📁 Entities/
│   │   │   ├── 📄 Customer.cs
│   │   │   ├── 📄 Order.cs
│   │   │   └── 📄 Product.cs
│   │   └── 📁 Interfaces/
│   │       └── 📄 IRepository.cs
│   ├── 📁 CopilotTraining.Application/
│   │   ├── 📁 Services/
│   │   │   └── 📄 OrderService.cs
│   │   └── 📁 DTOs/
│   │       └── 📄 OrderDto.cs
│   ├── 📁 CopilotTraining.Infrastructure/
│   │   └── 📁 Repositories/
│   │       └── 📄 OrderRepository.cs
│   └── 📁 CopilotTraining.Api/
│       └── 📁 Controllers/
│           └── 📄 OrdersController.cs
└── 📄 CopilotTraining.sln
```

---
### Next Session

Bringing this all into our work.

*Training materials version 3.1 | Last updated: 202602024 | Maintainer: Sean Keery*
