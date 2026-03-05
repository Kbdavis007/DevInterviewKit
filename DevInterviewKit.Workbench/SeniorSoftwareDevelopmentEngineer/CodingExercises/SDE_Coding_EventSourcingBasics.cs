/// <summary>
/// Purpose:
///   Interview exercise scaffold for implementing an event-sourced aggregate and projection.
/// Scenario:
///   A legal-case management bounded context must record state changes as domain events and provide
///   a read model for fast querying. The candidate must design an event-sourced aggregate, event
///   definitions, and a Marten projection pipeline such that the system remains consistent under
///   concurrent updates.
/// Requirements:
///   - Implement an event-sourced aggregate that captures case lifecycle changes (Open, Assign,
///     AddDocument, Close).
///   - Implement idempotent event handlers and projections using Marten's event store semantics.
///   - Provide optimistic concurrency control and conflict resolution guidance.
/// Constraints / Rules:
///   - No implementation in this scaffold file. This file only contains the exercise prompt.
///   - Assume PostgreSQL + Marten for event storage and Wolverine for messaging.
/// Technologies:
///   DDD, Event Sourcing, MartenDB, PostgreSQL, Wolverine, C# (modern), .NET 10
/// Difficulty: Senior
///
/// Use Case Directions:
///   Build an event-sourced `CaseAggregate` that persists domain events to Marten. Create at least
///   four domain events (CaseOpened, CaseAssigned, DocumentAdded, CaseClosed). Design a projection
///   that produces a `CaseSummary` document optimized for search and list pages. Ensure handlers
///   are idempotent and include guidance on how to handle duplicate events and concurrency.
///
///   The candidate should describe API surfaces, Marten configuration, projection lifecycle,
///   strategies for optimistic concurrency, and how to integrate Wolverine for asynchronous
///   side-effects (notifications, audit). Include tests and migration notes.
/// </summary>
internal static class SDE_Coding_EventSourcingBasics
{
}
