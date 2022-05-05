"use strict";
var connection = new signalR.HubConnectionBuilder().withUrl("/NotificationHub").build();
connection.on("sendToUser", (Heading, Content, Longitude, Latitude, SubscriberID) => {
    var heading = document.createElement("h3");
    heading.textContent = Heading;

    var p = document.createElement("p");
    p.innerText = Content;
    var q = document.createElement("p");
    q.innerText = Longitude;
    var r = document.createElement("p");
    r.innerText = Latitude;
    var s = document.createElement("p");
    s.innerText = SubscriberID;

    var div = document.createElement("div");
    div.appendChild(heading);
    div.appendChild(p);
    div.appendChild(q);
    div.appendChild(r);
    div.appendChild(s);
    
    document.getElementById("notificationList").appendChild(div);
});
connection.start().catch(function (err) {
    return console.error(err.toString());
});