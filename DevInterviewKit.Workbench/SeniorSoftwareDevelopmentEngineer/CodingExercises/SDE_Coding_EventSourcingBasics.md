# Event Sourcing Basics (Senior)

Overview
---
You are designing an event-sourced solution for a legal-case management bounded context. The system must store all state changes as immutable domain events in Marten (PostgreSQL) and expose a projection for quick UI queries.

Requirements
---
- Implement an event-sourced `CaseAggregate` with events: `CaseOpened`, `CaseAssigned`, `DocumentAdded`, `CaseClosed`.
- Write Marten event mappings and a projection that materializes a `CaseSummary` document.
- Ensure event handlers and projections are idempotent.
- Provide optimistic concurrency control for aggregate updates and detail how you would test concurrent scenarios.
- Integrate Wolverine to publish `CaseClosed` events to an external notification channel with outbox semantics.

Constraints
---
- Use Marten's event store for persistence and PostgreSQL for storage.
- Use Wolverine for messaging and outbox patterns.
- No external packages beyond Marten & Wolverine without justification.
- Provide unit and integration test guidance; do not implement in this prompt.

Acceptance Criteria
---
- Clear design for aggregate, event definitions, and projection.
- Idempotent projection strategy described.
- Concurrency handling approach with example test cases.
- Explanation of why Marten/Wolverine were chosen and trade-offs.

Follow-up Questions
---
- How would you handle large case attachments in the event stream?
- If projections fall behind, how would you bootstrap or rehydrate them?
- How to run projections in multi-node deployments?

Extensions
---
- Add snapshots to optimize aggregate rehydration.
- Model multi-tenant support for case data.
