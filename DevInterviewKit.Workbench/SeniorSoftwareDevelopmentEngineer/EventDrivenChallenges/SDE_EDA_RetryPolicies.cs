/// <summary>
/// Purpose:
///   Exercise scaffold for designing robust retry, backoff, and dead-letter strategies for message handlers.
/// Scenario:
///   A distributed message handler occasionally fails due to transient downstream errors. The candidate must
///   design retry semantics, idempotency guarantees, and DLQ behavior for long-running and short-running handlers.
/// Requirements:
///   - Explain retry strategies, exponential backoff, jitter, and maximum retry limits.
///   - Describe idempotency techniques and how to combine them with retries.
/// Constraints / Rules:
///   - No implementation; this file contains the interview prompt only.
/// Technologies:
///   Wolverine, Marten, Distributed systems, Observability
/// Difficulty: Senior////// Use Case Directions:///   Provide a design for retry policies, DLQ handling, and monitoring alerts. Include examples of when to fail-fast vs. retry,///   and how to ensure side-effects are not applied twice./// </summary>
internal static class SDE_EDA_RetryPolicies
{
}
