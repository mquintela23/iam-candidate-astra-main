function typeCategoryOnChange(ddlist, baseUrl, parameter) {
    var url = baseUrl + "OnSelectedDropDown/" + parameter;
    $.getJSON(url, parameter, function (data) {
        var items = [];
        data.forEach((item) => {
            var entry = "<option value='" + item.value + "'>" + item.text + "</option>";
            items.push(entry);
        });
        $(ddlist).html(items);
    });
};