# Architecture Scenario: Multi-Tenant Model (Principal)

Context
---
You are designing a multi-tenant SaaS platform for legal workflows. Tenants vary from small teams to large law firms with strict compliance and data residency requirements.

Task
---
Design a tenancy model and operational plan that addresses the following:
- Tenant isolation (data separation strategies).
- Projection and indexing strategy in Marten to handle high-volume tenants.
- Deployment and scaling approach (single cluster vs. per-tenant clusters).
- Backup, restore, and disaster recovery per tenant.

Constraints
---
- Use PostgreSQL and Marten; justify any additional infrastructure.
- Consider cost and operational complexity.

Acceptance Criteria
---
- Clear recommendation (shared vs isolated) with trade-offs.
- Strategy for tenant onboarding, schema changes, and migrations.
- Explanation of how to perform per-tenant restore and audits.

Trade-offs to Consider
---
- Cost vs. isolation (single DB saves cost but risks noisy neighbors).
- Complexity vs. performance (per-tenant DBs simplify compliance but increase operational burden).

Follow-up Questions
---
- How would you enforce tenant-specific retention policies?
- How to handle a cross-tenant global search that needs to respect tenant boundaries?
