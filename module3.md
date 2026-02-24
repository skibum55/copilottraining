## Module 3: Prompts Files & Project Instructions (15 minutes)

### 3.1 Understanding Prompts Files (3 min)

**What Are Prompts Files?**
- Markdown files that provide persistent instructions to Copilot
- Automatically loaded when working in your solution
- Act as "onboarding documentation" for your AI pair programmer

**File Locations:**

```
📁 CopilotTraining/
├── 📁 .github/
│   └── 📄 copilot-instructions.md    ← Solution-wide instructions
├── 📁 src/
│   └── 📁 CopilotTraining.Domain/
│       └── 📄 .copilot-prompts.md    ← Project-specific prompts
└── 📄 CopilotTraining.sln
```

**Why Use Prompts Files?**
- Consistency across all AI interactions
- Team coding standards automatically applied
- No need to repeat context in every prompt
- New team members get same AI behavior

### 3.2 Exercise 4: Create and Test a Prompts File (7 min)

**Objective:** Create a solution-wide prompts file and observe its effect

**Steps:**

1. Create folder `.github` in solution root
2. Create file `copilot-instructions.md` with this content:

```markdown
# CopilotTraining Solution Instructions

## Project Overview
This is a C# training solution demonstrating Clean Architecture patterns
with Domain, Application, Infrastructure, and API layers.

## Coding Standards
- Use nullable reference types (enable in all projects)
- Prefer expression-bodied members for simple methods
- All public methods require XML documentation comments
- Use async/await for all I/O operations
- Method names should be descriptive verbs (e.g., CalculateOrderTotal, not OrderTotal)

## Architecture Rules
- Domain entities have no dependencies on other layers
- Application layer contains business logic and service classes
- Infrastructure handles data access and external services
- API layer is thin - delegates to Application services

## Naming Conventions
- Interfaces prefixed with 'I' (IRepository, IOrderService)
- Async methods suffixed with 'Async' (GetOrderAsync)
- DTOs suffixed with 'Dto' (OrderDto, CustomerDto)
- Private fields prefixed with underscore (_orderRepository)

## Error Handling
- Use Result<T> pattern for operations that can fail
- Throw exceptions only for truly exceptional cases
- Validate inputs at API boundary

## AI Interaction Preferences
- Always ask clarifying questions before implementing complex features
- Plan before acting on tasks involving multiple files
- Explain reasoning when suggesting architectural decisions
- Present options for design decisions and let me choose
```

3. Save the file
4. **Restart Visual Studio** or reload the solution (required for Copilot to pick up the file)

5. Verify the prompts file - open Copilot Chat and enter:

```
Implement the UpdateOrderStatusAsync method in OrderService.
The method should update an order's status and save it.
```

**Observe:**
- Does Copilot ask clarifying questions? (AI Interaction Preferences)
- Does it include XML documentation? (Coding Standards)
- Does it use async properly? (Coding Standards)
- Does it follow naming conventions? (Naming Conventions)

### 3.3 Exercise 5: Compare AI Behavior With and Without Instructions (5 min)

**Objective:** See the concrete difference prompts files make

**Steps:**

1. With prompts file active, ask Copilot:

```
Create a method to find orders by customer ID
```

2. Note the response characteristics:
   - XML documentation included?
   - Async pattern used?
   - Naming conventions followed?
   - Did it ask questions or present options?

3. Temporarily rename `.github/copilot-instructions.md` to `.github/copilot-instructions.md.bak`

4. Restart Visual Studio or reload solution

5. Ask the same question:

```
Create a method to find orders by customer ID
```

6. Compare the two responses

7. **Restore the prompts file** (rename back to `copilot-instructions.md`)

**Discussion Points:**
- What differences did you notice?
- Which response better matched your team's standards?
- What other instructions might be valuable for your real projects?

---

## Module 4: Reusable Custom Prompts (15 minutes)

### 4.1 Why Create Reusable Prompts? (3 min)

**The Problem:**
- You find yourself typing the same instructions repeatedly
- Team members use inconsistent prompting approaches
- Best practices aren't shared across the team
- Complex prompts are hard to remember

**The Solution: Custom Prompt Templates**

```
┌─────────────────────────────────────────────────────────────┐
│              CUSTOM PROMPT WORKFLOW                         │
├─────────────────────────────────────────────────────────────┤
│                                                             │
│  1. IDENTIFY patterns in your prompting                    │
│     └─ "I always ask for validation when creating methods" │
│                                                             │
│  2. CREATE template with placeholders                       │
│     └─ Store in .github/copilot/prompts/                   │
│                                                             │
│  3. SHARE with team via source control                      │
│     └─ Everyone gets the same prompt quality               │
│                                                             │
│  4. INVOKE using @ reference or copy/paste                  │
│     └─ @workspace /prompt:create-service-method            │
│                                                             │
└─────────────────────────────────────────────────────────────┘
```

**Prompt Template Storage:**

```
📁 CopilotTraining/
├── 📁 .github/
│   ├── 📄 copilot-instructions.md
│   └── 📁 copilot/
│       └── 📁 prompts/
│           ├── 📄 create-service-method.md
│           ├── 📄 add-validation.md
│           ├── 📄 implement-endpoint.md
│           ├── 📄 code-review.md
│           └── 📄 refactor-method.md
