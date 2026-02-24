```

### 4.2 Anatomy of a Reusable Prompt (2 min)

**Template Structure:**

```markdown
# Prompt: Create Service Method

## Description
Use this prompt when implementing a new method in a service class.

## Variables
- {{METHOD_NAME}}: Name of the method to create
- {{DESCRIPTION}}: What the method should do
- {{RETURN_TYPE}}: Expected return type

## Prompt Template

I need to implement a method called {{METHOD_NAME}} that {{DESCRIPTION}}.

Expected return type: {{RETURN_TYPE}}

Before writing code:
1. Ask me clarifying questions about edge cases
2. Explain your planned approach
3. Identify any dependencies needed
4. Let me choose if there are multiple approaches

After I approve the approach:
1. Implement the method with full XML documentation
2. Include input validation
3. Follow our async patterns if I/O is involved
4. Explain any design decisions you made
```

### 4.3 Exercise 6: Build a Custom Prompt Library (5 min)

**Objective:** Create reusable prompt templates for common development tasks

**Steps:**

1. Create the prompts directory structure:
   - Create folder `.github/copilot/prompts/` in solution root

2. Create `create-service-method.md`:

```markdown
# Create Service Method

## Usage
Use when adding a new method to any service class.

## Template

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

3. Create `implement-endpoint.md`:

```markdown
# Implement API Endpoint

## Usage
Use when adding a new endpoint to a controller.

## Template

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

4. Create `code-review.md`:

```markdown
# Code Review Analysis

## Usage
Use to get AI-assisted review of selected code.

## Template

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

5. Verify all three files are saved

### 4.4 Exercise 7: Apply Reusable Prompts to Real Scenarios (5 min)

**Objective:** Use custom prompts to implement features consistently

**Steps:**

1. Open `OrderService.cs`
2. Open your `create-service-method.md` prompt template
3. Copy the template into Copilot Chat and fill in the placeholders:

```
I need to implement a new service method with these details:

**Method Name:** GetOrdersByCustomerIdAsync
**Purpose:** Retrieve all orders for a specific customer
**Input Parameters:** Guid customerId
**Return Type:** Task<IEnumerable<Order>>

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

4. Follow Copilot's questions and guidance
5. Implement the method

6. Now use the `implement-endpoint.md` template for the controller:

```
I need to add a new API endpoint with these details:

**HTTP Method:** GET
**Route:** api/orders/customer/{customerId}
**Purpose:** Get all orders for a specific customer
**Request Body:** None
**Response:** List of orders or empty array

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

7. Implement the endpoint

**Discussion Points:**
- How did using templates change your workflow?
- What other templates would be useful for your team?
- How might you customize these for your specific projects?

---
