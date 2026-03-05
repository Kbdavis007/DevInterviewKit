# Study Material: Event-Driven Systems (Intermediate - Senior)

Overview
---
Concise study guide for candidates preparing for senior backend roles involving event-driven architecture. Focus on patterns used in modern .NET systems with Marten and Wolverine.

Topics to Cover
---
- Message semantics: at-most-once, at-least-once, exactly-once (practical approximations).
- Idempotency patterns and deduplication strategies.
- Outbox pattern and transactional messaging with Marten.
- Saga patterns vs. choreography for long-running business processes.
- Retry/backoff strategies, poison messages, and dead-letter queues.
- Observability: distributed tracing, structured logging, metrics for message throughput and failures.

Constraints
---
- Anchor examples to Marten (event store) and Wolverine (message bus).
- Include brief code sketches (pseudocode) but no full implementations.

Acceptance Criteria
---
- Candidate can explain when to use sagas vs choreography.
- Candidate can describe how to make handlers idempotent.
- Candidate can outline an incident response for a stuck message/queue.

Follow-up Questions
---
- How would you test retry behavior in CI?
- Explain how network partitions affect message delivery guarantees.

Recommended Reading
---
- Patterns of Enterprise Application Architecture (Martin Fowler) — for classic patterns.
- Marten and Wolverine docs for concrete examples.
