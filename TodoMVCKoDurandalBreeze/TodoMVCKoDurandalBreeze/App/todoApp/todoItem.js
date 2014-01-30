var todoApp = todoApp || {};

todoApp.TodoItem = function (item, completed) {

    var self = this;

    self.item = ko.observable(item);
    self.completed = ko.observable(completed);
};
