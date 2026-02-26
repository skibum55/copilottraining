## Module 1: Foundations & Core Concepts (15 minutes)

### 1.1 Level Setting: Key Terminology (5 min)

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

**What is a Prompt?**
- Definition: Any input you provide to an AI assistant—questions, attachments (including images), instructions, code, comments, or context (including prior chat interactions)
- A prompt is your way of sharing context and communicating *intent* to the AI

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
│  │ "What patterns or interactions should I follow?"    │   │
│  │ "What constraints apply?"                           │   │
|  | "How can I complete or add to the content provided?"|   |
│  └─────────────────────────────────────────────────────┘   │
└─────────────────────────────────────────────────────────────┘
```

**Key Insight 1:** AI doesn't "know" your project—it *interprets* what you show it. Better prompts = better interpretation of your intent.

### 1.2 Standard Use Phrases (5 min)

**Phrases That Guide AI Behavior:**

These standard phrases help you control how the AI interacts with you:

| Phrase | Purpose | When to Use |
|--------|---------|-------------|
| **"Ask me questions for clarification"** | Ensures AI gathers requirements before acting | Starting complex tasks, unclear requirements |
| **"Plan before you act"** | AI outlines approach before writing code | Architecture decisions, multi-step implementations |
| **"Explain what you're doing"** | AI narrates its reasoning and choices | Learning, code review, understanding suggestions |
| **"Let me choose before we proceed"** | AI presents options instead of assuming | Multiple valid approaches, design decisions |

**Key Insight 2:** AI assumes you want it to respond with a finished answer or response if you don't provide instructions on how it should interact with you.

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

**Key Insight 3:** Notice how the good prompt above is made up of clear and concise statements. Be careful of broad and overly verbose sentences if you want AI to respond very specifically.

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

**Key Insight 4:** If you ask AI to include an existing file in your repo or your whole repo, it should let you know whether or not it has access to that content. In some cases, you may need to adjust your AI settings to allow access. Some models may not interact with content outside of the specific chat window.
**Key Insight 5:** It's reasonable to include the same "Before writing code:" instructions to AI for any following prompts to ensure AI has a clear understanding of your intent.
