// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function _OnChange(val) {
    if ($('#qty').val() != null || $('#qty').val() != "") {
        var value1 = $('#qty').val();
        $('#rate').val(val);
        $('#qty_kecil').val(val * value1);
    } else { 
        $('#rate').val(val);
        $('#qty_kecil').val('');
    }
}

function _OnkeyUp() { 
    var value1, value2;
    value1 = $('#rate').val();
    value2 = $('#qty').val();
    $('#qty_kecil').val(value1 * value2);
}

function _OnkeyUpDiscount() {
    var valuedisc = $('#discount').val(); 
    var qty = $('#qty').val();
    var unitprice = $('#unitprice').val();
    var valuedicround;
    var totaldiskon;
    var totalvalue = qty*unitprice;
    //cek regex char % & operator +
    if (!/[+%}]/.test(valuedisc)){
        $('#discountamt').val(valuedisc);
        $('#total').val(totalvalue-valuedisc);
    //cek operator +
    }else if (valuedisc.includes("+") || valuedisc.includes("%")){
            var str1 = valuedisc;
            var parts = str1.split(/\s*%\s*/);
            var totaldiskon = 0;
            var valuedicround = 0;
            for(let x in parts){
            parts[x].replace('+', "");
            //diskon bertingkat
            valuedicround = (qty*unitprice) * (parts[x].replace('+', "") /100);
            totaldiskon = totaldiskon + valuedicround;
            }
            $('#discountamt').val(totaldiskon);
            $('#total').val(totalvalue - totaldiskon);
    }
}