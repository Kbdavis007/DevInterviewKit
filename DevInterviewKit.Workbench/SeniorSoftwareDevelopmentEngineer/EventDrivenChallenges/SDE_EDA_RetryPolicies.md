# Event-Driven Challenge: Retries and Dead-Letters (Senior)

Overview
---
Design robust retry and error handling strategies for message-driven handlers in a distributed system.

Requirements
---
- Define retry policies for transient and non-transient failures.
- Recommend backoff algorithms and how to apply jitter.
- Define dead-letter queue policies and manual/automated remediation steps.
- Describe idempotency patterns to avoid duplicate side-effects.

Constraints
---
- Use Wolverine and Marten in your design where applicable.
- Consider cost of retries vs. durability of operations.

Acceptance Criteria
---
- Documented retry/backoff strategy and reasoning.
- Clear DLQ lifecycle and monitoring approach.
- Examples of idempotency implementations and their trade-offs.

Follow-up Questions
---
- How do you prioritize messages in a DLQ for replay?
- How to test retry behavior in CI/CD?
