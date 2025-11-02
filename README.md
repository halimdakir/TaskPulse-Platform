# TaskPulse: Intelligent Task Management and Insight Platform

It’s a team task management and insight platform, simple on the surface, but built with real-world technologies.

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

## Goals

- Learn .NET and Go together in one practical system
- Add an AI agent that provides real insights, not just data
- Understand event-driven design and background processing
- Build something that looks and feels like a real product
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

## Status

Currently working on the backend foundation and Docker setup.  
Frontend, worker, and AI agent will come next.

---

## About

I’m building this project to learn and share progress publicly. Feel free to follow along or give feedback!
