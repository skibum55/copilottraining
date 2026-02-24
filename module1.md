## Module 1: Foundations & Core Concepts (15 minutes)

### 1.1 Level Setting: Key Terminology (5 min)

**What is a Prompt?**
- Definition: Any input you provide to an AI assistant—questions, instructions, code comments, or context
- A prompt is your way of communicating *intent* to the AI
- Everything the AI "sees" becomes part of the prompt: your code, open files, comments, and explicit instructions

**How AI Perceives Your Prompts:**

```
┌─────────────────────────────────────────────────────────────┐
│                    YOUR PROMPT                              │
├─────────────────────────────────────────────────────────────┤
│  What AI Receives:                                          │
│  ┌─────────────┐ ┌─────────────┐ ┌─────────────────────┐   │
│  │ Your Text   │ │ Visible     │ │ Prompts Files &     │   │
│  │ & Comments  │ │ Code Context│ │ Instructions        │   │
│  └─────────────┘ └─────────────┘ └─────────────────────┘   │
│                         ↓                                   │
│              AI Interprets Your INTENT                      │
│                         ↓                                   │
│  ┌─────────────────────────────────────────────────────┐   │
│  │ "What is this person trying to accomplish?"         │   │
│  │ "What patterns should I follow?"                    │   │
│  │ "What constraints apply?"                           │   │
│  └─────────────────────────────────────────────────────┘   │
└─────────────────────────────────────────────────────────────┘
```

**Key Insight:** AI doesn't "know" your project—it *interprets* what you show it. Better prompts = better interpretation of your intent.

**Core Terminology Quick Reference:**

| Term | Definition |
|------|------------|
| **Prompt** | Any input/instruction given to the AI |
| **Intent** | The underlying goal the AI tries to interpret |
| **Context** | Surrounding information that shapes AI understanding |
| **Skills** | Reusable, scoped commands (like `/explain`, `/doc`) |
| **Prompts File** | Persistent instructions that apply to your project |
| **Instructions** | General guidance that shapes AI behavior |
| **Agent** | Specialized AI mode focused on specific tasks (workspace, code, etc.) |
| **Custom Prompt** | Reusable prompt template stored for repeated use |

### 1.2 Standard Use Phrases (5 min)

**Phrases That Guide AI Behavior:**

These standard phrases help you control how the AI interacts with you:

| Phrase | Purpose | When to Use |
|--------|---------|-------------|
| **"Ask me questions for clarification"** | Ensures AI gathers requirements before acting | Starting complex tasks, unclear requirements |
| **"Plan before you act"** | AI outlines approach before writing code | Architecture decisions, multi-step implementations |
| **"Explain what you're doing"** | AI narrates its reasoning and choices | Learning, code review, understanding suggestions |
| **"Let me choose before we proceed"** | AI presents options instead of assuming | Multiple valid approaches, design decisions |

**Poor vs. Good Prompts:**

```csharp
// ❌ Poor prompt - vague, no guidance
// Create a method to process orders

// ✅ Good prompt - clear intent with guidance
// Create a method to process orders that validates inventory,
// calculates totals, and updates status.
// Ask me questions for clarification before starting.
// Plan before you act, and let me choose between approaches.
```

### 1.3 Exercise 1: First Interaction with Copilot Chat (5 min)

**Objective:** Practice using standard phrases in Copilot Chat

**Steps:**

1. Open `OrderService.cs` in Visual Studio
2. Open Copilot Chat (Ctrl+Enter)
3. Enter the following prompt:

```
I need to implement the CreateOrderAsync method in this OrderService.

Before writing any code:
- Ask me questions for clarification
- Then explain your planned approach
- Let me choose before we proceed
```

4. Answer Copilot's clarifying questions:
   - "Yes, validate that products exist and have sufficient stock"
   - "Calculate total from unit prices × quantities"
   - "Set initial status to 'Pending'"

5. Review the proposed approach
6. **Do not implement yet** — we'll do this in Module 2

**Discussion Points:**
- What questions did Copilot ask?
- How did the guidance phrases change the interaction?
- Compare experiences across the group

