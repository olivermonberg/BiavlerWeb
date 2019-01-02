// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var footerNode = document.getElementById("footerId");
footerNode.innerHTML = footerNode.innerHTML + "<i>This page was last refreshed on: " + document.lastModified + "</i>";

var menuItemNode = document.getElementsByClassName("menuItem");
for (var i = 0; i < menuItemNode.length; i++) {
    menuItemNode[i].addEventListener("mouseover",
        function () {
            this.style.fontWeight = "bold";
        });
    menuItemNode[i].addEventListener("mouseout",
        function () {
            this.style.fontWeight = "normal";
        });
}