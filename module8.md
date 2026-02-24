```markdown
## Module 8: Visual Studio 2026 Interface Guide (Standalone Reference)

### Module Overview

| **Duration** | 20 minutes (standalone) or self-paced reference |
|--------------|--------------------------------------------------|
| **Purpose** | Comprehensive walkthrough of Copilot UI in VS 2026 |
| **Format** | Instructor demo with optional hands-on exploration |

---

### 8.1 Copilot Interface Overview (5 min)

**The Four Primary Interaction Points:**

```
┌─────────────────────────────────────────────────────────────────┐
│                    VS 2026 COPILOT INTERFACE                    │
├─────────────────────────────────────────────────────────────────┤
│                                                                 │
│  ┌─────────────┐    ┌─────────────┐    ┌─────────────────────┐ │
│  │   INLINE    │    │    CHAT     │    │   CONTEXT MENU      │ │
│  │ SUGGESTIONS │    │   WINDOW    │    │   (Right-click)     │ │
│  └─────────────┘    └─────────────┘    └─────────────────────┘ │
│        │                  │                      │              │
│        ▼                  ▼                      ▼              │
│  Ghost text in      Side panel or       Quick actions on       │
│  editor as you      floating window     selected code          │
│  type               for conversations                          │
│                                                                 │
│  ┌─────────────────────────────────────────────────────────┐   │
│  │                    TOOLS & OPTIONS                       │   │
│  │              Settings and configuration                  │   │
│  └─────────────────────────────────────────────────────────┘   │
│                                                                 │
└─────────────────────────────────────────────────────────────────┘
```

**[SCREENSHOT PLACEHOLDER: VS 2026 full interface with Copilot Chat panel open, showing inline suggestion in editor]**

---

### 8.2 Inline Suggestions (4 min)

**What Are Inline Suggestions?**

Inline suggestions appear as "ghost text" directly in your editor as you type. They predict what you want to write next based on:
- Your current code context
- Open files
- Comments and method signatures
- Prompts files (if configured)

**[SCREENSHOT PLACEHOLDER: Inline suggestion showing ghost text for a method implementation]**

**Triggering Inline Suggestions:**

| Action | How to Trigger |
|--------|----------------|
| Automatic | Start typing—suggestions appear automatically |
| Manual trigger | Press `Alt+\` to request a suggestion |
| After comment | Write a descriptive comment, press Enter |
| Method signature | Type method signature, suggestions complete body |

**[SCREENSHOT PLACEHOLDER: Comment-driven suggestion showing "// Calculate the total price for all items" followed by ghost text implementation]**

**Navigating Multiple Suggestions:**

When Copilot has multiple ideas, you can browse them:

| Action | Keyboard Shortcut |
|--------|-------------------|
| Next suggestion | `Alt+]` |
| Previous suggestion | `Alt+[` |
| Accept suggestion | `Tab` |
| Accept word-by-word | `Ctrl+Right Arrow` |
| Dismiss suggestion | `Esc` |

**[SCREENSHOT PLACEHOLDER: Suggestion navigation showing multiple suggestion indicator (1/3) in ghost text area]**

**Partial Acceptance:**

You don't have to accept entire suggestions:

1. **Accept by word**: Hold `Ctrl` and press `Right Arrow` to accept one word at a time
2. **Accept by line**: Some suggestions span multiple lines—accept just what you need, then modify
3. **Dismiss and retype**: Press `Esc`, adjust your comment or context, and trigger again

**[SCREENSHOT PLACEHOLDER: Partial acceptance showing accepted portion in regular text and remaining ghost text]**

---

### 8.3 Copilot Chat Window (4 min)

**Opening Copilot Chat:**

| Method | How |
|--------|-----|
| Keyboard shortcut | `Ctrl+Enter` |
| Menu | View → Copilot Chat |
| Toolbar | Click Copilot icon in toolbar |

**[SCREENSHOT PLACEHOLDER: Copilot Chat window docked on right side of VS, showing conversation history]**

**Chat Window Components:**

```
┌─────────────────────────────────────────────────────────────┐
│  COPILOT CHAT                                         [≡] X │
├─────────────────────────────────────────────────────────────┤
│                                                             │
│  ┌─────────────────────────────────────────────────────┐   │
│  │  CONVERSATION HISTORY                                │   │
│  │                                                      │   │
│  │  You: How do I implement validation for Order?      │   │
│  │                                                      │   │
│  │  Copilot: I'd recommend using FluentValidation...   │   │
│  │  [Code block with syntax highlighting]              │   │
│  │                                                      │   │
│  │  ┌──────────┐ ┌──────────┐ ┌──────────┐            │   │
│  │  │  Copy    │ │  Insert  │ │  New File│            │   │
│  │  └──────────┘ └──────────┘ └──────────┘            │   │
│  │                                                      │   │
│  └─────────────────────────────────────────────────────┘   │
│                                                             │
│  ┌─────────────────────────────────────────────────────┐   │
│  │  CONTEXT INDICATORS                                  │   │
│  │  📄 OrderService.cs  📄 Order.cs                    │   │
│  └─────────────────────────────────────────────────────┘   │
│                                                             │
│  ┌─────────────────────────────────────────────────────┐   │
│  │  Type your message...                    [@] [/] ➤  │   │
│  └─────────────────────────────────────────────────────┘   │
│                                                             │
└─────────────────────────────────────────────────────────────┘
```

**[SCREENSHOT PLACEHOLDER: Annotated chat window showing conversation history, context indicators, and input area]**

**Chat Input Features:**

| Feature | How to Access | Purpose |
|---------|---------------|---------|
| Agent selector | Type `@` | Choose @workspace, @code, @terminal, @docs |
| Skills | Type `/` | Access /explain, /fix, /doc, /optimize |
| File reference | Type `#` | Reference specific files in your prompt |
| Code selection | Select code first | Automatically includes in context |

**[SCREENSHOT PLACEHOLDER: Chat input showing @ dropdown menu with agent options]**

**[SCREENSHOT PLACEHOLDER: Chat input showing / dropdown menu with skill options]**

**Code Block Actions:**

When Copilot provides code in chat, action buttons appear:

| Button | Action |
|--------|--------|
| **Copy** | Copy code to clipboard |
| **Insert at Cursor** | Insert code at current editor position |
| **Insert in New File** | Create new file with the code |
| **Preview Changes** | See diff before applying |
| **Apply to File** | Apply directly to referenced file |

**[SCREENSHOT PLACEHOLDER: Code block in chat with action buttons highlighted]**

---

### 8.4 Inline Chat (Quick Chat) (3 min)

**What Is Inline Chat?**

Inline chat lets you have a conversation directly in the editor without opening the full chat panel. Perfect for quick questions or focused code changes.

**Opening Inline Chat:**

| Method | How |
|--------|-----|
| Keyboard shortcut | `Ctrl+I` |
| With selection | Select code, then `Ctrl+I` |

**[SCREENSHOT PLACEHOLDER: Inline chat popup appearing above selected code in editor]**

**Inline Chat Workflow:**

```
┌─────────────────────────────────────────────────────────────┐
│  public async Task<Order?> GetOrderAsync(Guid id)          │
│  {                                                          │
│      return await _orderRepository.GetByIdAsync(id);        │
│  }                                                          │
│                                                             │
│  ┌─────────────────────────────────────────────────────┐   │
│  │ 💬 Add null check and logging                  [➤]  │   │
│  └─────────────────────────────────────────────────────┘   │
│                                                             │
│  ┌─────────────────────────────────────────────────────┐   │
│  │  COPILOT RESPONSE                                    │   │
│  │                                                      │   │
│  │  public async Task<Order?> GetOrderAsync(Guid id)   │   │
│  │  {                                                   │   │
│  │ +    ArgumentNullException.ThrowIfNull(id);         │   │
│  │ +    _logger.LogDebug("Getting order {Id}", id);    │   │
│  │      var order = await _orderRepository...          │   │
│  │ +    if (order is null)                             │   │
│  │ +        _logger.LogWarning("Order not found");     │   │
│  │      return order;                                   │   │
│  │  }                                                   │   │
│  │                                                      │   │
│  │  [Accept] [Discard] [Regenerate] [Edit]             │   │
│  └─────────────────────────────────────────────────────┘   │
│                                                             │
└─────────────────────────────────────────────────────────────┘
```

**[SCREENSHOT PLACEHOLDER: Inline chat showing diff preview with Accept/Discard buttons]**

**Inline Chat Actions:**

| Button | Shortcut | Action |
|--------|----------|--------|
| Accept | `Ctrl+Enter` | Apply the changes |
| Discard | `Esc` | Cancel and close |
| Regenerate | - | Get a different suggestion |
| Edit | - | Modify your prompt and retry |

---

### 8.5 Inline Approvals & Diff View (3 min)

**Understanding Inline Approvals:**

When Copilot suggests changes to existing code, you see a diff view before accepting:

**[SCREENSHOT PLACEHOLDER: Side-by-side diff view showing original code and proposed changes with green/red highlighting]**

**Diff View Components:**

```
┌─────────────────────────────────────────────────────────────┐
│  PROPOSED CHANGES                                    [×]    │
├─────────────────────────────────────────────────────────────┤
│                                                             │
│  OrderService.cs                                            │
│  ──────────────────────────────────────────────────────    │
│  - public decimal CalculateTotal(Order order)              │
│  + public decimal CalculateOrderTotal(Order order)         │
│    {                                                        │
│  -     return order.Items.Sum(x => x.Price);               │
│  +     if (order?.Items == null || !order.Items.Any())     │
│  +         return 0m;                                       │
│  +                                                          │
│  +     return order.Items.Sum(item =>                       │
│  +         item.Quantity * item.UnitPrice);                │
│    }                                                        │
│                                                             │
├─────────────────────────────────────────────────────────────┤
│  [✓ Accept All] [Accept File] [✗ Discard] [Edit Request]   │
└─────────────────────────────────────────────────────────────┘
```

**[SCREENSHOT PLACEHOLDER: Inline diff view with accept/reject buttons for individual changes]**

**Approval Options:**

| Option | When to Use |
|--------|-------------|
| **Accept All** | Apply all proposed changes |
| **Accept File** | Apply changes to specific file only |
| **Accept Change** | Apply individual hunks/sections |
| **Discard** | Reject all changes |
| **Edit Request** | Modify prompt and regenerate |

**Partial Acceptance:**

You can accept or reject individual changes within a suggestion:

1. Hover over a specific change (green/red section)
2. Click the checkmark (✓) to accept or X to reject that change
3. After reviewing all changes, click "Apply Selections"

**[SCREENSHOT PLACEHOLDER: Individual change with hover showing accept/reject icons]**

---

### 8.6 Context Menu Integration (2 min)

**Right-Click Actions:**

When you right-click on selected code, Copilot options appear in the context menu:

**[SCREENSHOT PLACEHOLDER: Right-click context menu showing Copilot submenu expanded]**

**Available Context Menu Actions:**

| Action | Description |
|--------|-------------|
| **Explain This** | Opens chat with /explain for selected code |
| **Fix This** | Analyzes and suggests fixes |
| **Generate Documentation** | Creates XML docs for selection |
| **Optimize This** | Suggests performance improvements |
| **Add to Chat** | Sends selection to chat as context |
| **Ask Copilot** | Opens inline chat with selection |

**Quick Actions Lightbulb:**

The lightbulb (💡) that appears in the margin also includes Copilot suggestions:

**[SCREENSHOT PLACEHOLDER: Lightbulb menu showing Copilot-specific quick actions mixed with standard refactoring options]**

---

### 8.7 Tools & Options Configuration (4 min)

**Accessing Copilot Settings:**

Navigate to: Tools → Options → GitHub Copilot

**[SCREENSHOT PLACEHOLDER: Options dialog open to GitHub Copilot section]**

**Settings Categories:**

```
┌─────────────────────────────────────────────────────────────┐
│  OPTIONS                                                    │
├───────────────────┬─────────────────────────────────────────┤
│                   │                                         │
│  ▼ GitHub Copilot │  GENERAL SETTINGS                      │
│    ├─ General     │  ─────────────────────────────────     │
│    ├─ Suggestions │  ☑ Enable GitHub Copilot               │
│    ├─ Chat        │  ☑ Show inline suggestions             │
│    ├─ Skills      │  ☑ Enable Copilot Chat                 │
│    └─ Privacy     │                                         │
│                   │  Suggestion Delay: [300ms    ▼]        │
│                   │                                         │
│                   │  Default Agent: [@workspace  ▼]        │
│                   │                                         │
└───────────────────┴─────────────────────────────────────────┘
```

**General Settings:**

| Setting | Description | Recommended |
|---------|-------------|-------------|
| Enable Copilot | Master on/off toggle | ✓ On |
| Show inline suggestions | Ghost text in editor | ✓ On |
| Enable Copilot Chat | Chat panel functionality | ✓ On |
| Suggestion delay | Time before suggestions appear | 300ms |

**[SCREENSHOT PLACEHOLDER: General settings panel with options highlighted]**

**Suggestions Settings:**

| Setting | Description |
|---------|-------------|
| Languages | Enable/disable per language |
| File patterns | Exclude specific file patterns |
| Auto-complete triggers | What triggers suggestions |

**[SCREENSHOT PLACEHOLDER: Suggestions settings panel showing language toggles]**

**Chat Settings:**

| Setting | Description |
|---------|-------------|
| Default agent | Which agent to use by default |
| Conversation history | How much history to retain |
| Code block theme | Syntax highlighting style |

**[SCREENSHOT PLACEHOLDER: Chat settings panel]**

**Custom Skills Settings:**

| Setting | Description |
|---------|-------------|
| Skill definitions | JSON configuration for custom skills |
| Import/Export | Share skills with team |
| Skill enabled/disabled | Toggle individual skills |

**[SCREENSHOT PLACEHOLDER: Custom skills configuration panel showing JSON editor]**

**Privacy Settings:**

| Setting | Description |
|---------|-------------|
| Telemetry | What data is sent to GitHub |
| Code snippets | Whether snippets are used for training |
| Restricted files | Patterns to never send to Copilot |

**[SCREENSHOT PLACEHOLDER: Privacy settings panel with security-focused options]**

---

### 8.8 Keyboard Shortcuts Reference (2 min)

**Complete Shortcuts Table:**

| Category | Action | Windows | Mac |
|----------|--------|---------|-----|
| **Inline Suggestions** | | | |
| | Trigger suggestion | `Alt+\` | `Option+\` |
| | Accept suggestion | `Tab` | `Tab` |
| | Accept word | `Ctrl+Right` | `Cmd+Right` |
| | Next suggestion | `Alt+]` | `Option+]` |
| | Previous suggestion | `Alt+[` | `Option+[` |
| | Dismiss suggestion | `Esc` | `Esc` |
| **Chat** | | | |
| | Open Copilot Chat | `Ctrl+Enter` | `Cmd+Enter` |
| | Open Inline Chat | `Ctrl+I` | `Cmd+I` |
| | Submit message | `Enter` | `Enter` |
| | New line in chat | `Shift+Enter` | `Shift+Enter` |
| **Inline Approvals** | | | |
| | Accept changes | `Ctrl+Enter` | `Cmd+Enter` |
| | Discard changes | `Esc` | `Esc` |
| **Navigation** | | | |
| | Focus chat input | `Ctrl+L` | `Cmd+L` |
| | Clear chat | `Ctrl+K` | `Cmd+K` |

**[SCREENSHOT PLACEHOLDER: Keyboard shortcuts section in Tools > Options > Environment > Keyboard, filtered to "Copilot"]**

**Customizing Shortcuts:**

1. Go to Tools → Options → Environment → Keyboard
2. Search for "Copilot"
3. Select command to customize
4. Assign new shortcut
5. Click "Assign" then "OK"

**[SCREENSHOT PLACEHOLDER: Keyboard customization dialog with Copilot command selected]**

---

### 8.9 Status Bar & Notifications (1 min)

**Copilot Status Indicator:**

The status bar shows Copilot's current state:

```
┌─────────────────────────────────────────────────────────────┐
│                                                             │
│  [Other VS status items...]              🤖✓  Copilot Ready │
│                                                             │
└─────────────────────────────────────────────────────────────┘
```

**[SCREENSHOT PLACEHOLDER: Status bar showing Copilot icon with different states]**

**Status Icons:**

| Icon | Meaning |
|------|---------|
| 🤖✓ (Green check) | Copilot active and ready |
| 🤖⟳ (Spinning) | Processing request |
| 🤖⚠ (Warning) | Limited functionality |
| 🤖✗ (Red X) | Disabled or error |
| 🤖💤 (Sleep) | Paused for current file |

**Clicking the Status Icon:**

Click the Copilot status icon to:
- View current status details
- Enable/disable Copilot temporarily
- See account information
- Access quick settings

**[SCREENSHOT PLACEHOLDER: Status icon popup menu showing quick options]**

---

### 8.10 Interface Quick Reference Card

```
┌─────────────────────────────────────────────────────────────┐
│           VS 2026 COPILOT INTERFACE REFERENCE              │
├─────────────────────────────────────────────────────────────┤
│                                                             │
│  INLINE SUGGESTIONS (Ghost Text in Editor)                  │
│  ─────────────────────────────────────────                 │
│  Alt+\            Trigger suggestion                        │
│  Tab              Accept full suggestion                    │
│  Ctrl+Right       Accept word by word                       │
│  Alt+] / Alt+[    Next / Previous suggestion               │
│  Esc              Dismiss                                   │
│                                                             │
├─────────────────────────────────────────────────────────────┤
│                                                             │
│  COPILOT CHAT (Side Panel)                                  │
│  ─────────────────────────────────────────                 │
│  Ctrl+Enter       Open chat panel                          │
│  @                Select agent (@workspace, @code, etc.)   │
│  /                Access skills (/explain, /fix, etc.)     │
│  #                Reference specific files                  │
│                                                             │
├─────────────────────────────────────────────────────────────┤
│                                                             │
│  INLINE CHAT (Quick Editor Popup)                           │
│  ─────────────────────────────────────────                 │
│  Ctrl+I           Open inline chat                         │
│  Ctrl+Enter       Accept proposed changes                  │
│  Esc              Discard and close                        │
│                                                             │
├─────────────────────────────────────────────────────────────┤
│                                                             │
│  CONTEXT MENU (Right-Click)                                 │
│  ─────────────────────────────────────────                 │
│  Explain This     /explain selected code                   │
│  Fix This         /fix selected code                       │
│  Generate Docs    /doc selected code                       │
│  Ask Copilot      Open inline chat with context            │
│                                                             │
├─────────────────────────────────────────────────────────────┤
│                                                             │
│  SETTINGS                                                   │
│  ─────────────────────────────────────────                 │
│  Tools → Options → GitHub Copilot                          │
│    ├─ General      Enable/disable features                 │
│    ├─ Suggestions  Language and trigger settings           │
│    ├─ Chat         Default agent, history                  │
│    ├─ Skills       Custom skill definitions                │
│    └─ Privacy      Security and data settings              │
│                                                             │
├─────────────────────────────────────────────────────────────┤
│                                                             │
│  STATUS BAR                                                 │
│  ─────────────────────────────────────────                 │
│  🤖✓  Ready       🤖⟳  Processing                          │
│  🤖⚠  Warning     🤖✗  Error/Disabled                       │
│  Click icon for quick settings menu                        │
│                                                             │
└─────────────────────────────────────────────────────────────┘
```

---

### 8.11 Hands-On Interface Exploration (Optional - 5 min)

**If time permits, complete this self-guided exploration:**

**Task 1: Inline Suggestions**
1. Open any `.cs` file
2. Type `// Create a method that` and pause
3. Observe the inline suggestion
4. Press `Alt+]` to see alternatives
5. Accept with `Tab` or dismiss with `Esc`

**Task 2: Chat Panel**
1. Press `Ctrl+Enter` to open chat
2. Type `@workspace` and explore the agent dropdown
3. Type `/` and explore available skills
4. Ask: `@workspace What projects are in this solution?`

**Task 3: Inline Chat**
1. Select any method in your code
2. Press `Ctrl+I` to open inline chat
3. Type: `Add error handling`
4. Review the diff preview
5. Accept or discard the changes

**Task 4: Context Menu**
1. Select a block of code
2. Right-click and find the Copilot submenu
3. Try "Explain This"
4. Review the explanation in chat

**Task 5: Settings**
1. Go to Tools → Options → GitHub Copilot
2. Explore each settings category
3. Note the custom skills section for later use

---

### Screenshot Checklist for Training Materials

| # | Screenshot Description | Location in Module |
|---|------------------------|-------------------|
| 1 | Full VS interface with Copilot Chat open | 8.1 |
| 2 | Inline ghost text suggestion | 8.2 |
| 3 | Comment-driven suggestion | 8.2 |
| 4 | Multiple suggestion indicator | 8.2 |
| 5 | Partial acceptance example | 8.2 |
| 6 | Chat window docked | 8.3 |
| 7 | Annotated chat components | 8.3 |
| 8 | @ agent dropdown | 8.3 |
| 9 | / skills dropdown | 8.3 |
| 10 | Code block action buttons | 8.3 |
| 11 | Inline chat popup | 8.4 |
| 12 | Inline chat diff preview | 8.4 |
| 13 | Side-by-side diff view | 8.5 |
| 14 | Inline diff with accept/reject | 8.5 |
| 15 | Individual change hover icons | 8.5 |
| 16 | Right-click context menu | 8.6 |
| 17 | Lightbulb quick actions | 8.6 |
| 18 | Options dialog - Copilot | 8.7 |
| 19 | General settings panel | 8.7 |
| 20 | Suggestions settings | 8.7 |
| 21 | Chat settings | 8.7 |
| 22 | Custom skills JSON editor | 8.7 |
| 23 | Privacy settings | 8.7 |
| 24 | Keyboard shortcuts filter | 8.8 |
| 25 | Keyboard customization dialog | 8.8 |
| 26 | Status bar states | 8.9 |
| 27 | Status icon popup menu | 8.9 |

---

*Module 8 - Visual Studio Interface Guide | Version 1.0*
```