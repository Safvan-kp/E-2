function cate(name) {

    if (name == 2) {
        alert(name);
    }
    let c = '1';
    if (name == 0) {
        c = 'No Parent'
    }
    const node = document.getElementById('categ');
    //document.getElementById('categ').appendChild(node);
    document.getElementById('categ').innerHTML = c;
}