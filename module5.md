
## Module 5: Copilot Agents (15 minutes)

### 5.1 What Are Agents? (3 min)

**Definition:** Agents are specialized AI modes that have specific capabilities and context awareness. They're invoked using the `@` symbol.

**Built-in Agents in VS 2026:**

| Agent | Purpose | Best For |
|-------|---------|----------|
| `@workspace` | Understands your entire solution structure | Cross-file operations, finding code, architecture questions |
| `@code` | Focused on code generation and editing | Implementing methods, refactoring |
| `@terminal` | Understands command-line operations | Build commands, git operations, CLI tools |
| `@docs` | Searches documentation | API references, framework questions |

**Agent vs. Regular Chat:**

```
┌─────────────────────────────────────────────────────────────┐
│                    REGULAR CHAT                             │
├─────────────────────────────────────────────────────────────┤
│  • Sees only open files and your prompt                    │
│  • Good for focused, single-file tasks                     │
│  • Limited awareness of project structure                  │
└─────────────────────────────────────────────────────────────┘

┌─────────────────────────────────────────────────────────────┐
│                    @workspace AGENT                         │
├─────────────────────────────────────────────────────────────┤
│  • Can search and understand entire solution               │
│  • Aware of all files, references, dependencies            │
│  • Ideal for cross-cutting questions and changes           │
│  • Can find implementations, usages, patterns              │
└─────────────────────────────────────────────────────────────┘
```

### 5.2 When to Use Each Agent (2 min)

| Scenario | Agent to Use | Example Prompt |
|----------|--------------|----------------|
| "Where is X implemented?" | `@workspace` | `@workspace Where is IRepository implemented?` |
| "Write this method" | `@code` | `@code Implement CalculateOrderTotal` |
| "How do I build this?" | `@terminal` | `@terminal How do I run migrations?` |
| "How does this API work?" | `@docs` | `@docs How does FluentValidation work?` |
| "Refactor across files" | `@workspace` | `@workspace Rename OrderStatus to OrderState everywhere` |
| "What calls this method?" | `@workspace` | `@workspace Find all usages of GetOrderAsync` |

### 5.3 Exercise 8: Working with Workspace and Code Agents (5 min)

**Objective:** Use agents to understand and navigate the codebase

**Steps:**

1. **Explore with @workspace** - In Copilot Chat:

```
@workspace Give me an overview of this solution's architecture. 
What are the main projects and how do they relate to each other?
```

2. Review the architectural summary

3. **Find implementations** with @workspace:

```
@workspace Where is IRepository<T> implemented? 
Show me the concrete implementations.
```

4. **Understand dependencies** with @workspace:

```
@workspace What dependencies does OrderService have? 
Are there any circular dependencies in this solution?
```

5. **Use @code for focused generation**:

Open `OrderService.cs` and use:

```
@code Add a method called ValidateOrderAsync that:
- Takes an Order parameter
- Checks that the order has at least one item
- Verifies all product IDs exist using _productRepository
- Returns a ValidationResult with any errors

Explain your approach first.
```

6. Review the generated code

### 5.4 Exercise 9: Agent-Assisted Refactoring (5 min)

**Objective:** Use agents to perform cross-file refactoring

**Steps:**

1. First, understand the current state:

```
@workspace Find all places where order status is set or compared 
as a string (like "Pending", "Completed", etc.)
```

2. Plan the refactoring:

```
@workspace I want to replace the string-based order status with 
an enum called OrderStatus. 

Plan before you act:
- List all files that need to change
- Explain the migration approach
- Identify any potential breaking changes
- Let me choose before proceeding
```

3. Review the plan Copilot provides

4. If the plan looks good, proceed with phase 1:

```
@code Create the OrderStatus enum in the Domain/Entities folder with values:
- Pending
- Processing  
- Completed
- Cancelled

Include XML documentation for each value.
```

5. Implement the enum

6. Request the handoff summary:

```
@workspace Summarize what we've done so far in this refactoring 
and list the remaining steps with the files that need to change.
```

**Discussion Points:**
- How did @workspace help understand the codebase?
- When would you use @workspace vs regular chat?
- How could agents help with onboarding to a new project?

---
