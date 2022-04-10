window.addEventListener('message',(e) =>{
    if (e.data.type === "copy" ){
        copyToClipboard(e.data.text);
    }
})


function copyToClipboard(str) {
    const textarea = document.createElement('textarea');
    textarea.value = str;
    document.body.appendChild(textarea);
    textarea.select();
    document.execCommand('copy');
    textarea.remove();
}