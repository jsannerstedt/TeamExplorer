var TeamExplorer = {};

TeamExplorer.captureImages = function (selector) {
    var imageLoaded = function (src) {
        console.log(src);
        $("#issue-image").val(src);
        var previews = $(".previews"); // .find("ul.previews");
        var imageTag = '<li><img src="' + src + '" /></li>';
        previews.append(imageTag);
        var imageField = $('<input type="hidden" name="image" />');
        imageField.val(src);
        $("form").append(imageField);
    };

    /* This will only work for chrome... */
    document.onpaste = function (event) {
        var items = event.clipboardData.items;
        console.log(JSON.stringify(items));

        var blob = items[0].getAsFile();
        var reader = new FileReader();
        reader.onload = function (loaded) {
            imageLoaded(loaded.target.result);
        };

        reader.readAsDataURL(blob);
    };

};


