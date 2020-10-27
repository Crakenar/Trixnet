$(function () {
    url = 'https://localhost:44340/Contents/Lists/4m8echb7vw28ntmh8atae733wh/rss';
    $.ajax({
        type: "GET",
        url: document.location.protocol + '//ajax.googleapis.com/ajax/services/feed/load?v=1.0&num=1000&callback=?&q=' + encodeURIComponent(url),
        dataType: 'json',
        error: function () {
            alert('Unable to load feed, Incorrect path or invalid feed');
        },
        success: function (xml) {
            values = xml.responseData.feed.entries;

            $.each(values, function (index, value) {
                $('#myFeed').append(value.content);
                $('#myFeed').append('<br/>');
            });
        }
    });
});