// JavaScript for DenMotors application

// Initialize Blazor error handling
window.addEventListener('load', function () {
    // Find the error UI element
    const errorUiElement = document.getElementById('blazor-error-ui');
    
    if (errorUiElement) {
        // Handle errors from Blazor
        window.addEventListener('unhandledrejection', function (event) {
            errorUiElement.style.display = 'block';
        });
        
        // Add click handler for the dismiss button
        const dismissButtons = errorUiElement.getElementsByClassName('dismiss');
        for (let i = 0; i < dismissButtons.length; i++) {
            dismissButtons[i].addEventListener('click', function () {
                errorUiElement.style.display = 'none';
            });
        }
        
        // Add click handler for the reload link
        const reloadLinks = errorUiElement.getElementsByClassName('reload');
        for (let i = 0; i < reloadLinks.length; i++) {
            reloadLinks[i].addEventListener('click', function () {
                location.reload();
                return false;
            });
        }
    }
});