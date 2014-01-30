var todoApp = todoApp || {};

todoApp.todoViewModel = function () {

    var self = this;
    var todoList = ko.observableArray([]);
    var currentItem = ko.observable('');

    var vm = {
        todoList: todoList,
        currentItem: currentItem,
        addItem: addItem,
        deleteItem: deleteItem
    };

    addDummyData();
    return vm;

    function addItem() {
        vm.todoList.push(new todoApp.TodoItem(vm.currentItem(), false));
        vm.currentItem('');
    }

    function deleteItem(item) {
        vm.todoList.remove(item);
    }



    function addDummyData() {
        vm.todoList.push(new todoApp.TodoItem('Buy milk', false));
        vm.todoList.push(new todoApp.TodoItem('Buy beer', true));
    }

}();

