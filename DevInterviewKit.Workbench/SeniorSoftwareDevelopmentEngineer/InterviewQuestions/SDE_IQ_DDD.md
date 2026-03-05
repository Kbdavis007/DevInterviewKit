# Interview Questions: Domain-Driven Design (Senior)

Overview
---
A set of interview questions focused on DDD patterns, aggregates, bounded contexts, and event-driven modeling.

Questions
---
1. Explain the concept of a bounded context and give a real-world example where merging two bounded contexts would be a bad idea.
2. How do you decide what belongs inside an aggregate? Describe invariants and transactional boundaries.
3. Describe how you would model eventual consistency between two aggregates in different bounded contexts.
4. In an event-sourced system, how do you model queries? When do you introduce a projection vs. reading directly from events?
5. Describe a migration plan for converting a CRUD-style aggregate to event sourcing.

Constraints
---
- Expect candidates to discuss trade-offs and give concrete designs.

Acceptance Criteria
---
- Candidate demonstrates understanding of invariants and why aggregates enforce them.
- Candidate explains trade-offs between immediate consistency and scalability.

Follow-up/Extension
---
- Ask the candidate to draw the domain events for a case management flow and justify each event.
- Ask for tests that prove invariants are enforced in the aggregate.
