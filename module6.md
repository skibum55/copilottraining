
## Module 6: Custom Skills Library (12 minutes)

### 6.1 What Are Custom Skills? (3 min)

**Skills vs. Prompts:**

| Aspect | Custom Prompts | Custom Skills |
|--------|----------------|---------------|
| **Storage** | Markdown files in repo | VS settings/extension |
| **Invocation** | Copy/paste or reference | `/skillname` command |
| **Sharing** | Source control | Export/import or extension |
| **Parameters** | Manual substitution | Can accept arguments |
| **Best for** | Team-specific workflows | Frequent, standardized tasks |

**Built-in Skills Recap:**

| Skill | Purpose |
|-------|---------|
| `/explain` | Explain selected code |
| `/fix` | Suggest fixes for errors |
| `/doc` | Generate documentation |
| `/optimize` | Performance suggestions |
| `/simplify` | Reduce complexity |

### 6.2 Building Organization-Specific Skills (3 min)

**Custom Skill Configuration:**

Location: VS 2026 → Tools → Options → GitHub Copilot → Custom Skills

**Skill Definition Structure:**

```json
{
  "skills": [
    {
      "name": "api-endpoint",
      "description": "Generate a complete API endpoint with validation",
      "prompt": "Create an API endpoint following our standards: [DETAILED INSTRUCTIONS]",
      "parameters": [
        {
          "name": "httpMethod",
          "description": "HTTP method (GET, POST, PUT, DELETE)",
          "required": true
        },
        {
          "name": "route",
          "description": "API route path",
          "required": true
        }
      ]
    },
    {
      "name": "devops-workitem",
      "description": "Format commit/PR for Azure DevOps",
      "prompt": "Generate a commit message or PR description that references Azure DevOps work item AB#[number] extracted from the current branch name. Follow our PR template."
    },
    {
      "name": "validate-method",
      "description": "Add input validation to a method",
      "prompt": "Add comprehensive input validation to the selected method using guard clauses and FluentValidation if complex. Include XML documentation for the validation rules."
    }
  ]
}
```

### 6.3 Exercise 10: Create and Use a Custom Skill (6 min)

**Objective:** Create a custom skill and use it in your workflow

**Steps:**

1. Open VS 2026 → Tools → Options → GitHub Copilot → Custom Skills

2. Add a new skill definition:

```json
{
  "name": "service-method",
  "description": "Generate a service method with our team standards",
  "prompt": "Create a service method with the following requirements:\n- Include full XML documentation\n- Add input validation using guard clauses\n- Use async/await for any repository calls\n- Follow the patterns in the current file\n- Return appropriate Result<T> wrapper for operations that can fail\n\nAsk clarifying questions before implementing. Explain your approach."
}
```

3. Add another skill:

```json
{
  "name": "review",
  "description": "Perform a code review on selected code",
  "prompt": "Review the selected code for:\n1. Correctness and potential bugs\n2. Adherence to our coding standards\n3. Performance considerations\n4. Security concerns\n5. Suggested improvements\n\nFormat as a code review with severity ratings (Critical/Major/Minor/Nitpick)."
}
```

4. Save the configuration

5. Test the `/service-method` skill:
   - Open `OrderService.cs`
   - Open Copilot Chat
   - Type: `/service-method Create a method to cancel an order by ID`

6. Review the interaction—note how it follows your defined behavior

7. Test the `/review` skill:
   - Select the `GetOrderAsync` method
   - Type: `/review`
   - Review the code review output

**Team Skill Ideas:**

| Skill Name | Purpose |
|------------|---------|
| `/dto` | Generate DTO with mapping |
| `/repository-method` | Add method following repository pattern |
| `/handler` | Create MediatR handler |
| `/migration` | Scaffold EF migration |
| `/devops-pr` | Generate PR description for Azure DevOps |
| `/swagger-doc` | Add Swagger documentation attributes |

**Discussion Points:**
- What skills would be most valuable for your team?
- How would you maintain and version custom skills?
- Who should own the custom skills configuration?

---
