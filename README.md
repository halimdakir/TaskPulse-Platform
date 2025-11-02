# TaskPulse: Intelligent Task Management and Insight Platform

TaskPulse is a lightweight SaaS platform for intelligent task management and productivity insights. It’s a team task management and insight platform, simple on the surface, but built with real-world technologies.

---

## What it is

TaskPulse helps teams and individuals manage tasks, deadlines, and productivity insights. The goal is to mix a clean API, a lightweight worker service, and an AI-powered insight assistant, just like a real SaaS system.

---

## Tech stack

**Backend (Core API)** – ASP.NET Core  
Handles authentication, projects, and tasks. Talks to PostgreSQL and publishes events.

**Worker Service** – Go  
Listens for new tasks and processes background work like summaries or notifications.

**AI Agent** – Python or .NET  
Analyzes task history and generates natural-language productivity insights.

**Frontend** – React + TypeScript  
A clean dashboard that shows tasks, progress, and AI-driven insights.

**Database** – PostgreSQL  
Main data store shared between services.

**Infra** – Docker Compose  
Runs the full stack locally with one command.

---

## Folder structure

    taskpulse/
    ├── api-dotnet/             → ASP.NET Core backend
    ├── worker-go/              → Go background worker
    ├── ai-agent/               → AI service for task insights
    ├── web-frontend/           → React + TypeScript dashboard
    ├── docker-compose.yml      → Local development setup
    └── docs/                   → Diagrams, notes, and roadmap



---

## Getting started

For now, you can open `api-dotnet` in Rider or VS Code and run the API directly.  
More setup instructions will be added as the stack grows.

---

