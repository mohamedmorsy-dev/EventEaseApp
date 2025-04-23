using EventEaseApp.Models;

public class EventService
{
    public readonly List<EventModel> _events = new()
   {
       new EventModel
       {
           Id = 0,
           Title = "Blazor Workshop",
           Description = "Learn the basics of Blazor in this hands-on workshop.",
           Date = new DateTime(2025, 5, 1),
           Location = "Online"
       },
       new EventModel
       {
           Id = 1,
           Title = "Tech Conference 2025",
           Description = "Join us for the annual tech conference featuring top speakers.",
           Date = new DateTime(2025, 6, 15),
           Location = "San Francisco, CA"
       },
       new EventModel
       {
           Id = 2,
           Title = "AI Summit",
           Description = "Explore the latest in AI technology and applications.",
           Date = new DateTime(2025, 7, 10),
           Location = "New York, NY"
       },
       new EventModel
       {
           Id = 3,
           Title = "Cloud Expo",
           Description = "Dive into cloud computing trends and innovations.",
           Date = new DateTime(2025, 8, 20),
           Location = "Seattle, WA"
       },
       new EventModel
       {
           Id = 4,
           Title = "Cybersecurity Forum",
           Description = "Discuss the latest in cybersecurity challenges and solutions.",
           Date = new DateTime(2025, 9, 5),
           Location = "Austin, TX"
       },
       new EventModel
       {
           Id = 5,
           Title = "Web Development Bootcamp",
           Description = "Master modern web development techniques.",
           Date = new DateTime(2025, 10, 12),
           Location = "Online"
       },
       new EventModel
       {
           Id = 6,
           Title = "Data Science Workshop",
           Description = "Hands-on training in data analysis and machine learning.",
           Date = new DateTime(2025, 11, 18),
           Location = "Chicago, IL"
       },
       new EventModel
       {
           Id = 7,
           Title = "Mobile App Hackathon",
           Description = "Build innovative mobile apps in a competitive environment.",
           Date = new DateTime(2025, 12, 3),
           Location = "Los Angeles, CA"
       },
       new EventModel
       {
           Id = 8,
           Title = "Blockchain Conference",
           Description = "Learn about blockchain technology and its applications.",
           Date = new DateTime(2026, 1, 15),
           Location = "Miami, FL"
       },
       new EventModel
       {
           Id = 9,
           Title = "Game Development Summit",
           Description = "Explore the latest trends in game development.",
           Date = new DateTime(2026, 2, 20),
           Location = "Las Vegas, NV"
       },
       new EventModel
       {
           Id = 10,
           Title = "IoT Innovations",
           Description = "Discover the future of Internet of Things technology.",
           Date = new DateTime(2026, 3, 8),
           Location = "Denver, CO"
       },
       new EventModel
       {
           Id = 11,
           Title = "AR/VR Expo",
           Description = "Experience the latest in augmented and virtual reality.",
           Date = new DateTime(2026, 4, 22),
           Location = "San Jose, CA"
       },
       new EventModel
       {
           Id = 12,
           Title = "Startup Pitch Night",
           Description = "Pitch your startup ideas to investors and mentors.",
           Date = new DateTime(2026, 5, 30),
           Location = "Boston, MA"
       },
       new EventModel
       {
           Id = 13,
           Title = "DevOps Day",
           Description = "Learn about DevOps practices and tools.",
           Date = new DateTime(2026, 6, 14),
           Location = "Portland, OR"
       },
       new EventModel
       {
           Id = 14,
           Title = "Quantum Computing Workshop",
           Description = "Understand the basics of quantum computing.",
           Date = new DateTime(2026, 7, 25),
           Location = "Online"
       },
       new EventModel
       {
           Id = 15,
           Title = "Robotics Expo",
           Description = "Showcase of the latest advancements in robotics.",
           Date = new DateTime(2026, 8, 10),
           Location = "Detroit, MI"
       }
   };

    public IEnumerable<EventModel> GetEvents() => _events;

    public async Task<EventModel?> GetEventByIdAsync(int id)
    {
        // Simulate fetching data asynchronously  
        await Task.Delay(100); // Replace with actual data fetching logic  
        return _events.FirstOrDefault(e => e.Id == id);
    }

    public void AddEvent(EventModel newEvent) => _events.Add(newEvent);

    public void RemoveEvent(int id)
    {
        if (id >= 0 && id < _events.Count)
        {
            _events.RemoveAt(id);
        }
    }
}
