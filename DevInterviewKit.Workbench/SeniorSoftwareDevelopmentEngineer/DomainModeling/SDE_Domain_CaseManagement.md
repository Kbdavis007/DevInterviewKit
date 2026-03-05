# Domain Modeling: Case Management (Senior)

Context
---
Design a domain model for a legal case management system. Focus on the `Case` aggregate and closely related concepts.

Requirements
---
- Define aggregates and boundaries for: `Case`, `Party`, `Document`, `Hearing`.
- List domain events and explain when they occur.
- Define invariants that the aggregate must enforce (e.g., no duplicate primary counsel, cannot close while mandatory tasks are open).
- Provide examples of commands and resulting events.

Constraints
---
- Keep aggregates small and consistent with DDD guidance.
- Prefer composition over inheritance for value objects.

Acceptance Criteria
---
- Candidate produces a clear model with entities, value objects, and invariants.
- Candidate justifies aggregate boundaries and transaction scopes.

Follow-up Questions
---
- When would you split responsibilities into separate aggregates?
- How to model attachments that are large binary blobs?
