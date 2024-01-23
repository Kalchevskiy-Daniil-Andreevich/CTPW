using System.Net.WebSockets;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace lab01b.Controllers;

public class WebSocketController : ControllerBase
{
    [Route("/ws")]
    public async Task Get()
    {
        if (HttpContext.WebSockets.IsWebSocketRequest)
        {
            using var webSocket = await HttpContext.WebSockets.AcceptWebSocketAsync();
            await Echo(webSocket);
        }
        else
        {
            HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
        }
    }

    private static async Task Echo(WebSocket webSocket)
    {
        var buffer = new byte[1024 * 4];
        var receiveResult = await webSocket.ReceiveAsync(
            new ArraySegment<byte>(buffer), CancellationToken.None);

        while (true)
        {
            var response = Encoding.UTF8.GetBytes(DateTime.Now.ToString("HH:mm:ss"));
            await webSocket.SendAsync(
                new ArraySegment<byte>(response, 0, response.Length),
                WebSocketMessageType.Text,
                true,
                CancellationToken.None);
            
            await Task.Delay(2000);
        }
    }
}
