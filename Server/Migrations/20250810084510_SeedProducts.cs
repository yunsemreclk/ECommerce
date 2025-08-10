using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "IsActive", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, "Ergonomic wireless mouse with USB receiver", "https://example.com/products/mouse.jpg", true, "Wireless Mouse", 149.99m, 50 },
                    { 2, "RGB mechanical keyboard with blue switches", "https://example.com/products/keyboard.jpg", true, "Mechanical Keyboard", 349.00m, 30 },
                    { 3, "24-inch full HD monitor with HDMI input", "https://example.com/products/monitor.jpg", true, "HD Monitor", 899.99m, 15 },
                    { 4, "6-in-1 USB-C hub with HDMI and SD card reader", "https://example.com/products/hub.jpg", true, "USB-C Hub", 79.50m, 100 },
                    { 5, "Over-ear gaming headset with noise cancellation", "https://example.com/products/headset.jpg", true, "Gaming Headset", 249.00m, 25 },
                    { 6, "High-speed 1TB portable SSD with USB 3.2", "https://example.com/products/ssd.jpg", true, "Portable SSD 1TB", 1199.99m, 40 },
                    { 7, "Full HD webcam with built-in microphone", "https://example.com/products/webcam.jpg", true, "Webcam 1080p", 199.95m, 60 },
                    { 8, "Portable Bluetooth speaker with 12-hour battery life", "https://example.com/products/speaker.jpg", true, "Bluetooth Speaker", 329.99m, 80 },
                    { 9, "Fitness tracking smartwatch with heart rate monitor", "https://example.com/products/smartwatch.jpg", true, "Smartwatch", 499.00m, 20 },
                    { 10, "Adjustable aluminum laptop stand for desk use", "https://example.com/products/laptopstand.jpg", true, "Laptop Stand", 89.00m, 75 },
                    { 11, "Fast wireless charger for all Qi-enabled devices", "https://example.com/products/charger.jpg", true, "Wireless Charger", 179.99m, 35 },
                    { 12, "In-ear noise-cancelling Bluetooth earbuds", "https://example.com/products/earbuds.jpg", true, "Noise-Cancelling Earbuds", 699.00m, 45 },
                    { 13, "Professional graphic tablet with pressure sensitivity", "https://example.com/products/tablet.jpg", true, "Graphic Tablet", 1299.00m, 10 },
                    { 14, "Smart LED lamp with voice control and color settings", "https://example.com/products/lamp.jpg", true, "Smart Lamp", 259.50m, 22 },
                    { 15, "2TB external hard drive with USB 3.0", "https://example.com/products/hdd.jpg", true, "External Hard Drive 2TB", 649.99m, 55 },
                    { 16, "Fitness tracker with sleep and step monitoring", "https://example.com/products/fitnesstracker.jpg", true, "Fitness Tracker", 299.00m, 60 },
                    { 17, "Waterproof 4K action camera with accessories", "https://example.com/products/camera.jpg", true, "4K Action Camera", 799.99m, 18 },
                    { 18, "USB condenser microphone for streaming and recording", "https://example.com/products/mic.jpg", true, "Desktop Microphone", 329.00m, 40 },
                    { 19, "3-port HDMI switch with remote control", "https://example.com/products/hdmiswitch.jpg", true, "HDMI Switch", 99.99m, 70 },
                    { 20, "Dual-band gigabit wireless router with wide coverage", "https://example.com/products/router.jpg", true, "Wireless Router", 599.00m, 28 },
                    { 21, "Color-changing LED strip with remote and app control", "https://example.com/products/ledstrip.jpg", true, "LED Strip Light", 119.99m, 90 },
                    { 22, "High-back ergonomic office chair with lumbar support", "https://example.com/products/chair.jpg", true, "Ergonomic Office Chair", 1599.00m, 12 },
                    { 23, "Next-gen virtual reality headset with motion tracking", "https://example.com/products/vr.jpg", true, "VR Headset", 1999.00m, 8 },
                    { 24, "Compact projector with HDMI and USB support", "https://example.com/products/projector.jpg", true, "Mini Projector", 499.99m, 26 },
                    { 25, "4K media streaming stick with voice remote", "https://example.com/products/stream.jpg", true, "Streaming Stick", 299.00m, 65 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);
        }
    }
}
