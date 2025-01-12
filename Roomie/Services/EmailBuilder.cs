using Roomie.Domain;

namespace Roomie.Services
{
    public class EmailBuilder
    {
        public SendEmailRequest CreateBookingConfirmationEmail(Building building, Booking booking, decimal totalPrice)
        {
            var emailTitle = $"Booking confirmation for room {booking.RoomNumber} at {building.Name}";
            var emailBody = $$"""
            <!DOCTYPE html>
            <html lang="en">
            <head>
                <meta charset="UTF-8">
                <meta name="viewport" content="width=device-width, initial-scale=1.0">
                <title>Booking Confirmation</title>
                <style>
                    body {
                        font-family: Arial, sans-serif;
                        background-color: #f4f4f4;
                        margin: 0;
                        padding: 0;
                    }
                    .container {
                        width: 100%;
                        max-width: 600px;
                        margin: 0 auto;
                        background-color: #ffffff;
                        padding: 20px;
                        border-radius: 8px;
                        box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                    }
                    .header {
                        color: black;
                        padding: 10px 0;
                        text-align: center;
                        border-top-left-radius: 8px;
                        border-top-right-radius: 8px;
                    }
                    .header img {
                        max-width: 100%;
                        height: auto;
                        border-top-left-radius: 8px;
                        border-top-right-radius: 8px;
                    }
                    .content {
                        padding: 20px;
                    }
                    .button {
                        display: inline-block;
                        background-color: #4CAF50;
                        color: #ffffff;
                        padding: 10px 20px;
                        text-decoration: none;
                        border-radius: 5px;
                    }
                </style>
            </head>
            <body>
                <div class="container">
                    <div class="header">
                        <img src="https://celinesaratwedding.com/Images/celine_sarat_home.jpg" alt="Celine & Sarat" />
                        <h1>Booking Confirmation</h1>
                    </div>
                    <div class="content">
                        <p>Dear {{booking.FirstName}} {{booking.LastName}},</p>
                        <p>Thank you for booking a room with us. Here are the details of your booking:</p>
                        <ul>
            				<li><strong>Room number:</strong> {{booking.RoomNumber}}</li>
            				<li><strong>Building:</strong> {{building.Name}}</li>
            				<li><strong>Address:</strong> 36 Rue de l'Ancienne Mairie, Saint-Yrieix-sur-Charente, Nouvelle-Aquitaine 16710, France</li>
                            <li><strong>Day(s) of choice:</strong> {{booking.DayChoice}}</li>
                            <li><strong>Total Price:</strong> {{totalPrice}} €</li>
                        </ul>
            			<a href="https://celinesaratwedding.com/edit-booking/{{booking.BuildingId}}/{{booking.RoomNumber}}/{{booking.Token}}/{{booking.Email}}" class="button">Edit booking</a>
                        <p>Payment is due upon arrival. If you have any questions or need further assistance, please feel free to <a href="mailto:saratcelinewedding@gmail.com">contact us</a>.</p>
                        <p>We look forward to celebrating our wedding with you!</p>
                        <p>Best regards,</p>
                        <p>Celine & Sarat</p>
                    </div>
                </div>
            </body>
            </html>
            
            """;
            return new SendEmailRequest(booking.Email, emailTitle, emailBody);
        }

        public SendEmailRequest CreateBookingEditEmail(Building building, Booking booking, decimal totalPrice)
        {
            var emailTitle = $"Booking update for room {booking.RoomNumber} at {building.Name}";
            var emailBody = $$"""
            <!DOCTYPE html>
            <html lang="en">
            <head>
                <meta charset="UTF-8">
                <meta name="viewport" content="width=device-width, initial-scale=1.0">
                <title>Booking Confirmation</title>
                <style>
                    body {
                        font-family: Arial, sans-serif;
                        background-color: #f4f4f4;
                        margin: 0;
                        padding: 0;
                    }
                    .container {
                        width: 100%;
                        max-width: 600px;
                        margin: 0 auto;
                        background-color: #ffffff;
                        padding: 20px;
                        border-radius: 8px;
                        box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                    }
                    .header {
                        color: black;
                        padding: 10px 0;
                        text-align: center;
                        border-top-left-radius: 8px;
                        border-top-right-radius: 8px;
                    }
                    .header img {
                        max-width: 100%;
                        height: auto;
                        border-top-left-radius: 8px;
                        border-top-right-radius: 8px;
                    }
                    .content {
                        padding: 20px;
                    }
                    .button {
                        display: inline-block;
                        background-color: #4CAF50;
                        color: #ffffff;
                        padding: 10px 20px;
                        text-decoration: none;
                        border-radius: 5px;
                    }
                </style>
            </head>
            <body>
                <div class="container">
                    <div class="header">
                        <img src="https://celinesaratwedding.com/Images/celine_sarat_home.jpg" alt="Celine & Sarat" />
                        <h1>Booking Update</h1>
                    </div>
                    <div class="content">
                        <p>Dear {{booking.FirstName}} {{booking.LastName}},</p>
                        <p>Your booking has been updated, here are the new details:</p>
                        <ul>
            				<li><strong>Room number:</strong> {{booking.RoomNumber}}</li>
            				<li><strong>Building:</strong> {{building.Name}}</li>
            				<li><strong>Address:</strong> 36 Rue de l'Ancienne Mairie, Saint-Yrieix-sur-Charente, Nouvelle-Aquitaine 16710, France</li>
                            <li><strong>Day(s) of choice:</strong> {{booking.DayChoice}}</li>
                            <li><strong>Total Price:</strong> {{totalPrice}} €</li>
                        </ul>
            			<a href="https://celinesaratwedding.com/edit-booking/{{booking.BuildingId}}/{{booking.RoomNumber}}/{{booking.Token}}/{{booking.Email}}" class="button">Edit booking</a>
                        <p>Payment is due upon arrival. If you have any questions or need further assistance, please feel free to <a href="mailto:saratcelinewedding@gmail.com">contact us</a>.</p>
                        <p>We look forward to celebrating our wedding with you!</p>
                        <p>Best regards,</p>
                        <p>Celine & Sarat</p>
                    </div>
                </div>
            </body>
            </html>
            
            """;
            return new SendEmailRequest(booking.Email, emailTitle, emailBody);
        }
    }
}
