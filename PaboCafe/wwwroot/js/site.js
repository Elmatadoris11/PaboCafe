// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let currentImageIndex = 0;
const images = document.querySelectorAll('.imageshow');
const totalImages = images.length;
const imageSlider = document.querySelector('.image-slider');

function showImage(index) {
    currentImageIndex = (index + totalImages) % totalImages;
    const newPosition = -currentImageIndex * 100 + '%';
    imageSlider.style.transform = 'translateX(' + newPosition + ')';
}

function prevImage() {
    showImage(currentImageIndex - 1);
}

function nextImage() {
    showImage(currentImageIndex + 1);
}
