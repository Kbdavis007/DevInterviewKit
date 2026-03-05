# DevInterviewKit – Repository Instructions

## Purpose
This repository provides a structured system for senior-level backend interview preparation. It includes coding exercises, architecture scenarios, domain‑driven design challenges, event‑driven workflows, PostgreSQL optimization tasks, and text‑based questions. The goal is to simulate real-world engineering problems aligned with modern .NET 8+, DDD, Marten, Wolverine, and distributed systems practices.

## How Copilot Should Use These Instructions
Copilot should generate content, code, exercises, and explanations that:
- Reflect senior backend engineering expectations.
- Align with Domain‑Driven Design (strategic and tactical patterns).
- Use modern .NET 10+ idioms and best practices.
- Correctly apply MartenDB, Wolverine, CQRS, and event‑sourcing patterns.
- Incorporate PostgreSQL performance considerations.
- Encourage architectural reasoning, trade‑off analysis, and communication clarity.
- Produce realistic, production‑grade scenarios rather than toy examples.

Copilot should treat this repository as a training environment and generate material that helps the user practice coding, architecture, modeling, debugging, communication, and system design.

## Rules and Expectations

### Domain‑Driven Design
- Use bounded contexts, aggregates, entities, value objects, domain services, and domain events correctly.
- Maintain invariants and enforce consistency boundaries.
- Use ubiquitous language and domain‑rich examples.
- Prefer realistic legal/workflow/regulated domain scenarios.

### Event‑Driven Architecture
- Use asynchronous messaging patterns.
- Ensure handlers are idempotent.
- Include retry policies, dead‑letter queues, and observability considerations.
- Model event flows, choreography, and orchestration accurately.

### MartenDB
- Use event sourcing, projections, and multi‑document sessions.
- Model documents and events realistically.
- Include tenancy and auditability when relevant.

### Wolverine (.NET Critter Stack)
- Generate message handlers, middleware, and pipelines.
- Use outbox patterns and error-handling features.
- Model distributed workflows and message-driven processes.

### PostgreSQL
- Use indexing, partitioning, and query tuning.
- Consider high-throughput workloads and concurrency.
- Include realistic schema and query examples.

### Architecture & Engineering Excellence
- Encourage clean architecture boundaries.
- Include ADR-style reasoning when generating design decisions.
- Include testing strategies: unit, integration, and contract tests.
- Consider resiliency, observability, and CI/CD implications.

### Communication & Leadership
- Provide prompts requiring explanation of trade-offs.
- Include scenarios involving mentoring or cross-team collaboration.
- Encourage clear articulation of domain logic to non-technical stakeholders.

### Output Requirements
- Use clear structure: headings, lists, constraints, acceptance criteria.
- Include difficulty levels (Intermediate, Senior, Principal).
- Provide follow-up questions or extensions.
- Prefer realistic, production-like scenarios.
- Avoid trivial or overly simplistic problems unless explicitly requested.

## Examples of What Copilot Should Generate

### Coding Exercise Example
- Implement an idempotent Wolverine message handler that processes a domain event and updates a Marten projection. Include constraints, edge cases, and test expectations.

### Architecture Scenario Example
- Design a bounded context for a legal case workflow system. Identify aggregates, invariants, domain events, and integration points with other contexts.

### PostgreSQL Optimization Example
- Given a high-throughput event log table, propose indexing and partitioning strategies and explain the trade-offs.

### Behavioral/Communication Example
- “Explain to a product manager why an aggregate cannot span multiple bounded contexts.”

## Limitations
Copilot should not:
- Generate outdated .NET patterns.
- Produce trivial coding puzzles unless explicitly asked.
- Contradict DDD principles or event-sourcing fundamentals.
- Simplify domain problems to the point of losing realism.
- Produce content unrelated to backend engineering, architecture, or interview preparation.
