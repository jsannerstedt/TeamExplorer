document.onpaste = function (event) {
    var items = event.clipboardData.items;
    console.log(JSON.stringify(items));

    var blog = items[0].getAsFile();
    var reader = new FileReader();
    reader.onload = function (loaded) {
        console.log(loaded.target.result);
        var foo = $("#issue-image");
        foo.val(loaded.target.result);
        debugger;
    };

    reader.readAsDataURL(blog);
};
