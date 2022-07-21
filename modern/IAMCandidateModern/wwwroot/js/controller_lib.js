function categoryOnChange(ddList, baseUrl, parameter) {
    var url = baseUrl + "api/elements/" + parameter;
    $.getJSON(url, "", function (data) {
        var items = [];
        data.forEach((item) => {
            var entry = "<option value='" + item.value + "'>" + item.text + "</option>";
            items.push(entry);
        });
        $(ddList).html(items);
    });
};

function typeCategoryOnChange(baseUrl, category, typeCategory, callback) {
    var url = baseUrl + "api/elements/category/" + category + "/categoryType/" + typeCategory;
    $.getJSON(url, "", function (data) {
        callback(data);
    });
};