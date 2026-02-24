## Appendix A: Complete Sample Prompts File Template

```markdown
# Copilot Instructions for [Project Name]

## Project Overview
[Brief description of what this project does]

## Technology Stack
- .NET Version: 8.0
- C# Version: 12
- Key NuGet Packages: [list main packages]

## Architecture
[Describe your architecture pattern]

## Coding Conventions
### Naming
- [Your naming conventions]

### Patterns
- [Required design patterns]

### Error Handling
- [How errors should be handled]

## AI Interaction Preferences
- Ask clarifying questions before implementing complex features
- Plan before acting on multi-file changes
- Explain reasoning for architectural suggestions
- Present options for design decisions

## Azure DevOps Integration
- Work item format: AB#[number]
- Branch naming convention: feature/AB#[number]-description
- PR requirements: [specify]

## Multi-Phase Work
- For features estimated > 2 hours, create phased plan first
- Each phase should be completable in single session
- Always generate handoff summary between phases

## Do Not Generate
- [Any patterns or code you want to avoid]
```

---

## Appendix B: Reusable Prompt Templates Library

### Template: Create Service Method
```markdown
I need to implement a new service method with these details:

**Method Name:** [SPECIFY NAME]
**Purpose:** [DESCRIBE WHAT IT DOES]
**Input Parameters:** [LIST PARAMETERS]
**Return Type:** [SPECIFY RETURN TYPE]

Before writing any code:
- Ask me 2-3 clarifying questions about requirements
- Identify any existing methods I should reuse
- Plan your approach and explain it
- Let me choose between approaches if multiple exist

When implementing:
- Include complete XML documentation
- Add input validation with guard clauses
- Use async/await if any I/O operations
- Follow the patterns established in this codebase
```

### Template: Implement API Endpoint
```markdown
I need to add a new API endpoint with these details:

**HTTP Method:** [GET/POST/PUT/DELETE]
**Route:** [SPECIFY ROUTE]
**Purpose:** [DESCRIBE WHAT IT DOES]
**Request Body:** [DESCRIBE OR "None"]
**Response:** [DESCRIBE EXPECTED RESPONSE]

Before implementing:
- Ask clarifying questions about validation requirements
- Confirm the service method I should call
- Plan the implementation approach

When implementing:
- Add appropriate HTTP attributes
- Include XML documentation for Swagger
- Handle errors and return appropriate status codes
- Follow RESTful conventions
```

### Template: Code Review
```markdown
Please review the selected code and provide feedback on:

1. **Correctness**: Are there any bugs or logical errors?
2. **Naming**: Do names clearly convey intent?
3. **Patterns**: Does it follow our established patterns?
4. **Edge Cases**: What edge cases might not be handled?
5. **Improvements**: What specific improvements do you suggest?

For each issue found:
- Explain why it's a concern
- Provide a specific suggestion to fix it
- Rate severity: Critical / Important / Minor / Nitpick

Ask me if you need more context about any part of the code.
```

### Template: Refactoring Plan
```markdown
I need to refactor the following:

**Current State:** [DESCRIBE WHAT EXISTS]
**Desired State:** [DESCRIBE THE GOAL]
**Reason:** [WHY THIS REFACTORING]

Before making any changes:
1. Use @workspace to find all affected files
2. Create a phased plan with clear boundaries
3. Identify potential breaking changes
4. Let me review and approve the plan

For each phase:
- List specific files to modify
- Describe the changes
- Note any dependencies on other phases
```

---

## Appendix C: Custom Skills Starter Pack

```json
{
  "skills": [
    {
      "name": "service-method",
      "description": "Generate a service method with team standards",
      "prompt": "Create a service method with: full XML docs, input validation via guard clauses, async/await for repo calls, Result<T> wrapper for failable operations. Ask questions first, explain approach."
    },
    {
      "name": "review",
      "description": "Code review with severity ratings",
      "prompt": "Review selected code for: correctness, standards adherence, performance, security, improvements. Format as code review with Critical/Major/Minor/Nitpick ratings."
    },
    {
      "name": "dto",
      "description": "Generate DTO with mapping configuration",
      "prompt": "Create a DTO for the selected entity. Include: record type, nullable annotations, AutoMapper profile configuration. Follow our DTO naming conventions."
    },
    {
      "name": "devops-pr",
      "description": "Generate Azure DevOps PR description",
      "prompt": "Generate a PR description that: references work item AB#[number] from branch name, summarizes changes, lists affected components, notes any breaking changes. Follow our PR template."
    },
    {
      "name": "guard",
      "description": "Add guard clauses to method",
      "prompt": "Add comprehensive guard clauses to the selected method for all parameters. Use ArgumentNullException.ThrowIfNull, ArgumentException for invalid values. Add XML docs for exceptions."
    }
  ]
}
```
*Training materials version 3.0 | Last updated: 20260224 | Maintainer: Sean Keery*