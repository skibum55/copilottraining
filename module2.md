## Module 2: Multi-Phase Planning & Complex Tasks (15 minutes)

### 2.1 Why Multi-Phase Planning Matters (3 min)

**The Problem with Single-Prompt Approaches:**
- AI has context limits—can't hold entire complex implementations
- Large tasks lose coherence when attempted all at once
- No checkpoints for validation or course correction
- Difficult to track progress or hand off work

**The Solution: Break Complex Work into Phases**

```
┌────────────────────────────────────────────────────────────────┐
│                  MULTI-PHASE WORKFLOW                          │
├────────────────────────────────────────────────────────────────┤
│                                                                │
│  PHASE 1: Planning                                             │
│  └─ AI asks questions, creates step-by-step plan              │
│                          ↓                                     │
│  PHASE 2-N: Execution (one step per session)                   │
│  └─ Implement each step with review checkpoints               │
│                          ↓                                     │
│  PHASE END: Summary & Handoff                                  │
│  └─ AI summarizes decisions and context for next phase        │
│                                                                │
└────────────────────────────────────────────────────────────────┘
```

### 2.2 Exercise 2: Create a Phased Implementation Plan (5 min)

**Objective:** Use Copilot to create a multi-phase plan for completing the OrderService

**Steps:**

1. Open Copilot Chat
2. Enter the following prompt:

```
I need to complete the OrderService class with the following TODO items:
- CreateOrderAsync
- UpdateOrderStatusAsync  
- CalculateOrderTotalAsync

I also need to:
- Add corresponding controller endpoints
- Add XML documentation for all public methods
- Implement input validation

Create a phased implementation plan where:
- Each phase can be completed in 10-15 minutes
- Each phase builds on the previous one
- Include what files will be modified in each phase

Ask me any clarifying questions first.
Plan before you act.
```

3. Answer any clarifying questions from Copilot
4. Review the proposed plan
5. Copy the plan somewhere for reference (notepad, comment block, etc.)

**Expected Plan Structure:**
- Phase 1: Implement CalculateOrderTotalAsync (foundation method)
- Phase 2: Implement CreateOrderAsync (uses calculate method)
- Phase 3: Implement UpdateOrderStatusAsync
- Phase 4: Add controller endpoints
- Phase 5: Add validation and documentation

### 2.3 Exercise 3: Execute Phase One with Guided Prompts (7 min)

**Objective:** Implement the first phase using proper prompting techniques

**Steps:**

1. In Copilot Chat, start the first phase:

```
Let's start Phase 1: Implement CalculateOrderTotalAsync

Context:
- This method calculates the total for an order based on its items
- Each OrderItem has Quantity and UnitPrice
- The Order entity has a TotalAmount property

Explain your approach before writing the code.
```

2. Review Copilot's explanation
3. If satisfied, respond:

```
That approach looks good. Please implement CalculateOrderTotalAsync.
Explain what you're doing as you write the code.
```

4. Copy the generated code into `OrderService.cs`:

```csharp
public decimal CalculateOrderTotal(Order order)
{
    if (order.Items == null || !order.Items.Any())
        return 0m;

    return order.Items.Sum(item => item.Quantity * item.UnitPrice);
}
```

5. Now request the handoff summary:

```
We've completed Phase 1. Please provide a summary that includes:
- What was implemented
- Any decisions made
- Context needed for Phase 2 (CreateOrderAsync)
```

6. Save the summary for reference

**Discussion Points:**
- How does phased work differ from asking for everything at once?
- What value does the handoff summary provide?

