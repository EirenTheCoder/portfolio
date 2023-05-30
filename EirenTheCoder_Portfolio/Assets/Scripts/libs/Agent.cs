using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class Agent
{
    public Vector3 position;
    public Vector3 velocity;
    public Vector3 desired;
    public float maxSpeed = 5f;
    public float maxSteer = 0.5f;

    public Agent()
    {
        position = Vector3.zero;
        velocity = Vector3.zero;
        desired = Vector3.zero;
    }

    public void AddSeek(Vector3 targetPosition, float range = Mathf.Infinity, float weight = 1f)
    {
        Vector3 desired = Vector3.zero;
        if (Vector3.Distance(position, targetPosition) < range)
        {
            desired = (targetPosition - position).normalized * maxSpeed;
        }
        this.desired += desired * weight;
    }

    public void AddFlee(Vector3 targetPosition, float range = Mathf.Infinity, float weight = 1f)
    {
        Vector3 desired = Vector3.zero;
        if (Vector3.Distance(position, targetPosition) < range)
        {
            desired = (position - targetPosition).normalized * maxSpeed;
        }
        this.desired += desired * weight;
    }

    public void AddArrive(Vector3 targetPosition, float range = Mathf.Infinity, float arriveDistance = 50f, float weight = 1f)
    {
        Vector3 desired = Vector3.zero;
        float distance = Vector3.Distance(position, targetPosition);
        if (distance < range)
        {
            if (distance > arriveDistance)
            {
                desired = (targetPosition - position).normalized * maxSpeed;
            }
            else
            {
                float speed = Mathf.Lerp(0f, maxSpeed, distance / arriveDistance);
                desired = (targetPosition - position).normalized * speed;
            }
        }
        this.desired += desired * weight;
    }

    public void AddSeparate(Agent[] neighbors, float separation = 50f, float weight = 1f)
    {
        Vector3 desired = Vector3.zero;
        int count = 0;
        foreach (Agent other in neighbors)
        {
            float distance = Vector3.Distance(position, other.position);
            if (distance > 0 && distance < separation)
            {
                Vector3 diff = (position - other.position).normalized / distance;
                desired += diff;
                count++;
            }
        }
        if (count > 0)
        {
            desired /= count;
            desired = desired.normalized * maxSpeed;
        }
        this.desired += desired * weight;
    }

    public void AddWander(float strength = 0.1f, float weight = 1f)
    {
        strength = (strength / 10f);
        float wanderRadius = 1f;
        float wanderDistance = wanderRadius * strength;
        float wanderAngle = Random.Range(0f, Mathf.PI * 2f);
        Vector3 wanderDirection = new Vector3(Mathf.Cos(wanderAngle), 0f, Mathf.Sin(wanderAngle)).normalized * wanderRadius;
        Vector3 wanderPosition = position + wanderDirection + (velocity.normalized * wanderDistance);
        Vector3 desired = (wanderPosition - position).normalized * maxSpeed;
        this.desired += desired * weight;
    }

    public void AddInsideRectangle(float x = 0f, float y = 0f, float width = 1f, float height = 1f, float weight = 1f, float margin = 0f)
    {
        if (position.x < x + margin ||
            position.x > x + width - margin ||
            position.y < y + margin ||
            position.y > y + height - margin)
        {
            Vector3 center = new Vector3(x + width / 2f, y + height / 2f, 0f);
            Vector3 desired = (center - position).normalized * maxSpeed;
            this.desired += desired * weight;
        }
    }

    public void AddInsideCircle(float x = 0f, float y = 0f, float radius = 100f, float weight = 1f, float margin = 0f)
    {
        if (Vector3.Distance(position, new Vector3(x, y, 0f)) > radius - margin)
        {
            Vector3 desired = (new Vector3(x, y, 0f) - position).normalized * maxSpeed;
            this.desired += desired * weight;
        }
    }

    public void Update()
    {
        Vector3 steer = (desired - velocity).normalized * maxSteer;
        velocity += steer;
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
        position += velocity;
        desired = Vector3.zero;
    }
}
