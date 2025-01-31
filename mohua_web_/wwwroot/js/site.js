// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// Add a close button
const closeButton = document.createElement('div');
closeButton.classList.add('close-button');
closeButton.textContent = '×';
closeButton.addEventListener('click', () => {
    const videoWrapper = document.querySelector('.video-wrapper');
    videoWrapper.remove();
});

const videoContent = document.querySelector('.video-content');
videoContent.appendChild(closeButton);