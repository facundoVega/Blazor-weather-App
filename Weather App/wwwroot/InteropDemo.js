window.copyToClipboard = str => {
    if (navigator && navigator.clipboard && navigator.clipboard.writeText)
        return navigator.clipboard.writeText(str);
    return Promise.reject('The Clipboard API is not available.');
};


window.showError = function(tittle, errorMessage){
    Swal.fire({
        icon: 'error',
        tittle: tittle,
        text: errorMessage,
        footer: '<a href="mailto:demo@demo.com">Contact us if the problem persists</a>'
    });
};