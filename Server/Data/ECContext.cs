namespace Server.Data;

using Microsoft.EntityFrameworkCore;
using Server.Entity;

public class ECContext : DbContext
{
    public ECContext(DbContextOptions<ECContext> options) : base(options)
    {

    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Cart> Carts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Wireless Mouse", Price = 149.99m, Description = "Ergonomic wireless mouse with USB receiver", ImageUrl = "https://example.com/products/mouse.jpg", IsActive = true, Stock = 50 },
            new Product { Id = 2, Name = "Mechanical Keyboard", Price = 349.00m, Description = "RGB mechanical keyboard with blue switches", ImageUrl = "https://example.com/products/keyboard.jpg", IsActive = true, Stock = 30 },
            new Product { Id = 3, Name = "HD Monitor", Price = 899.99m, Description = "24-inch full HD monitor with HDMI input", ImageUrl = "https://example.com/products/monitor.jpg", IsActive = true, Stock = 15 },
            new Product { Id = 4, Name = "USB-C Hub", Price = 79.50m, Description = "6-in-1 USB-C hub with HDMI and SD card reader", ImageUrl = "https://example.com/products/hub.jpg", IsActive = true, Stock = 100 },
            new Product { Id = 5, Name = "Gaming Headset", Price = 249.00m, Description = "Over-ear gaming headset with noise cancellation", ImageUrl = "https://example.com/products/headset.jpg", IsActive = true, Stock = 25 },
            new Product { Id = 6, Name = "Portable SSD 1TB", Price = 1199.99m, Description = "High-speed 1TB portable SSD with USB 3.2", ImageUrl = "https://example.com/products/ssd.jpg", IsActive = true, Stock = 40 },
            new Product { Id = 7, Name = "Webcam 1080p", Price = 199.95m, Description = "Full HD webcam with built-in microphone", ImageUrl = "https://example.com/products/webcam.jpg", IsActive = true, Stock = 60 },
            new Product { Id = 8, Name = "Bluetooth Speaker", Price = 329.99m, Description = "Portable Bluetooth speaker with 12-hour battery life", ImageUrl = "https://example.com/products/speaker.jpg", IsActive = true, Stock = 80 },
            new Product { Id = 9, Name = "Smartwatch", Price = 499.00m, Description = "Fitness tracking smartwatch with heart rate monitor", ImageUrl = "https://example.com/products/smartwatch.jpg", IsActive = true, Stock = 20 },
            new Product { Id = 10, Name = "Laptop Stand", Price = 89.00m, Description = "Adjustable aluminum laptop stand for desk use", ImageUrl = "https://example.com/products/laptopstand.jpg", IsActive = true, Stock = 75 },
            new Product { Id = 11, Name = "Wireless Charger", Price = 179.99m, Description = "Fast wireless charger for all Qi-enabled devices", ImageUrl = "https://example.com/products/charger.jpg", IsActive = true, Stock = 35 },
            new Product { Id = 12, Name = "Noise-Cancelling Earbuds", Price = 699.00m, Description = "In-ear noise-cancelling Bluetooth earbuds", ImageUrl = "https://example.com/products/earbuds.jpg", IsActive = true, Stock = 45 },
            new Product { Id = 13, Name = "Graphic Tablet", Price = 1299.00m, Description = "Professional graphic tablet with pressure sensitivity", ImageUrl = "https://example.com/products/tablet.jpg", IsActive = true, Stock = 10 },
            new Product { Id = 14, Name = "Smart Lamp", Price = 259.50m, Description = "Smart LED lamp with voice control and color settings", ImageUrl = "https://example.com/products/lamp.jpg", IsActive = true, Stock = 22 },
            new Product { Id = 15, Name = "External Hard Drive 2TB", Price = 649.99m, Description = "2TB external hard drive with USB 3.0", ImageUrl = "https://example.com/products/hdd.jpg", IsActive = true, Stock = 55 },
            new Product { Id = 16, Name = "Fitness Tracker", Price = 299.00m, Description = "Fitness tracker with sleep and step monitoring", ImageUrl = "https://example.com/products/fitnesstracker.jpg", IsActive = true, Stock = 60 },
            new Product { Id = 17, Name = "4K Action Camera", Price = 799.99m, Description = "Waterproof 4K action camera with accessories", ImageUrl = "https://example.com/products/camera.jpg", IsActive = true, Stock = 18 },
            new Product { Id = 18, Name = "Desktop Microphone", Price = 329.00m, Description = "USB condenser microphone for streaming and recording", ImageUrl = "https://example.com/products/mic.jpg", IsActive = true, Stock = 40 },
            new Product { Id = 19, Name = "HDMI Switch", Price = 99.99m, Description = "3-port HDMI switch with remote control", ImageUrl = "https://example.com/products/hdmiswitch.jpg", IsActive = true, Stock = 70 },
            new Product { Id = 20, Name = "Wireless Router", Price = 599.00m, Description = "Dual-band gigabit wireless router with wide coverage", ImageUrl = "https://example.com/products/router.jpg", IsActive = true, Stock = 28 },
            new Product { Id = 21, Name = "LED Strip Light", Price = 119.99m, Description = "Color-changing LED strip with remote and app control", ImageUrl = "https://example.com/products/ledstrip.jpg", IsActive = true, Stock = 90 },
            new Product { Id = 22, Name = "Ergonomic Office Chair", Price = 1599.00m, Description = "High-back ergonomic office chair with lumbar support", ImageUrl = "https://example.com/products/chair.jpg", IsActive = true, Stock = 12 },
            new Product { Id = 23, Name = "VR Headset", Price = 1999.00m, Description = "Next-gen virtual reality headset with motion tracking", ImageUrl = "https://example.com/products/vr.jpg", IsActive = true, Stock = 8 },
            new Product { Id = 24, Name = "Mini Projector", Price = 499.99m, Description = "Compact projector with HDMI and USB support", ImageUrl = "https://example.com/products/projector.jpg", IsActive = true, Stock = 26 },
            new Product { Id = 25, Name = "Streaming Stick", Price = 299.00m, Description = "4K media streaming stick with voice remote", ImageUrl = "https://example.com/products/stream.jpg", IsActive = true, Stock = 65 }
        );
    }

}