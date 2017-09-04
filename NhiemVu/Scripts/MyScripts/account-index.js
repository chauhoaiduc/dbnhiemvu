function removefile(event, error) {
    if (error == 1) {
        var countHinh = $("#countErrHinh").val();
        countHinh--;
        $("#countErrHinh").val(countHinh);
        if (countHinh == 0) {
            $("#errHinh").remove();
        }
        event.target.closest(".w3-bar-item").remove();
    } else if (error == 2) {
        var countTapTin = $("#countErrTapTin").val();
        countTapTin--;
        $("#countErrTapTin").val(countTapTin);
        if (countTapTin == 0) {
            $("#errTapTin").remove();
        }

    }
    event.target.closest(".w3-bar-item").remove();
}

$(".w3-bar").on('change','input[name="TapTin"]',function () {
    var index = $(this).attr("id");
    index++;
    $(this).siblings().eq(0).remove();
    var html = '';
    html += '<a onclick="removefile(event)" class="w3-transparent w3-hover-gray w3-display-topright">&times;</a>';
        
    var extDoc = ['doc', 'docx'];
    var extExcel = ['xls', 'xlsx'];
    var extZip = ['zip', 'rar'];
    var extSQL = ['sql'];
    var extCode = ['js', 'css','cs'];
    var fileName = event.target.files[0].name;
    var fileNameExt = fileName.substr(fileName.lastIndexOf('.') + 1);
    if ($.inArray(fileNameExt, extDoc) != -1) {
        html += '<h3><label><i class="fa fa-file-word-o w3-button w3-padding-large w3-text-blue" aria-hidden="true"></i></label></h3>';
    } else if ($.inArray(fileNameExt, extExcel) != -1)
    {
        html += '<h3><label><i class="fa fa-file-excel-o w3-button w3-padding-large w3-text-teal" aria-hidden="true"></i></label></h3>';
    } else if ($.inArray(fileNameExt, extZip) != -1) {
        html += '<h3><label><i class="fa fa-file-archive-o w3-button w3-padding-large w3-text-purple" aria-hidden="true"></i></label></h3>';
    } else if ($.inArray(fileNameExt, extSQL) != -1) {
        html += '<h3><label><i class="fa fa-file-text-o w3-button w3-padding-large w3-text-orange" aria-hidden="true"></i></label></h3>';
    } else if ($.inArray(fileNameExt, extCode) != -1) {
        html += '<h3><label><i class="fa fa-file-code-o w3-button w3-padding-large w3-text-teal" aria-hidden="true"></i></label></h3>';
    }else{
        html = '';
        html += '<a onclick="removefile(event,2)" class="w3-transparent w3-hover-gray w3-display-topright">&times;</a>';
        html += '<h3><label><i class="fa fa-file-o w3-button w3-padding-large" aria-hidden="true"></i></label></h3>';
        var count = $("#countErrTapTin").val();
        count++;
        $("#countErrTapTin").val(count);
        if ($("#errTapTin").length == 0)
        {
            $("#bar-taptin").after('<p id="errTapTin" class="w3-text-red">Vui lòng chọn định dạng file là xls, xlsx, doc, docs, txt, zip, rar, js, css, cs, sql !</p>');
        }
            
    }
        
    $(this).after(html);

    html = '<div class="w3-margin-right w3-bar-item w3-border w3-border-gray w3-pale-blue w3-display-container">';
    html += '       <input type="file" hidden class="form-control validate" id="' + index + 'TapTin" name="TapTin">';
    html+='       <h3><label for="'+index+'TapTin"><i class="fa fa-file w3-button w3-padding-large w3-text-teal" aria-hidden="true"></i></label></h3>';
    html += '</div>';
    $(this).closest(".w3-bar-item").before(html);
        
});

$(".w3-bar").on('change', 'input[name="Hinh"]', function () {
    var index = parseInt($(this).attr("id"));
    index++;
    $(this).siblings().eq(0).remove();
    var html = '';
    html += '<a onclick="removefile(event)" class="w3-transparent w3-hover-gray w3-display-topright">&times;</a>';

    var extHinh = ['png', 'jpg'];
    var fileName = event.target.files[0].name;
    var fileNameExt = fileName.substr(fileName.lastIndexOf('.') + 1);
    if ($.inArray(fileNameExt, extHinh) == -1) {
        html = '';
        html += '<a onclick="removefile(event,1)" class="w3-transparent w3-hover-gray w3-display-topright">&times;</a>';
        var count = $("#countErrHinh").val();
        count++;
        $("#countErrHinh").val(count);
        if ($("#errHinh").length == 0) {
            $("#bar-hinh").after('<p id="errHinh" class="w3-text-red">Vui lòng chọn định dạng file là png hoặc jpg !</p>');
        }
    }

    html += '<h3><label><img style="width:73px;height:53px" src="" /></label></h3>';
    $(this).after(html);
    var output = $(this).siblings().eq(1).find("img");

    output.attr("src", URL.createObjectURL(event.target.files[0]));

    html = '<div class="w3-margin-right w3-bar-item w3-border w3-border-gray w3-pale-blue w3-display-container">';
    html += '       <input type="file" hidden class="form-control validate" id="' + index + 'Hinh" name="Hinh">';
    html += '       <h3><label for="' + index + 'Hinh"><i class="fa fa-camera w3-button w3-padding-large w3-text-teal" aria-hidden="true"></i></label></h3>';
    html += '</div>';
    $(this).closest(".w3-bar-item").before(html);

        
});

$('.datepicker').datepicker({
    format: 'mm/dd/yyyy',
    todayHighlight: true,
    autoclose: true
});
    
function setNgay() {
    var today = new Date();
    $('.datepicker').val(today.toLocaleDateString());
}
    





function refresh() {
    $("input[name='vTenNhiemVu']").val('');
    $("textarea[name='vMoTa']").val('');
    setNgay();
    refreshHinh();
    refreshTapTin();
}

function refreshHinh() {
    $("#countErrHinh").val(0);
    $("#bar-hinh").empty();
    $("#errHinh").remove();
    var html = '';
    html += '<div class="w3-margin-right w3-bar-item w3-border w3-border-gray w3-pale-blue w3-display-container">';
    html += '     <input type="file" hidden class="form-control validate" id="1Hinh" name="Hinh">';
    html += '     <h3>';
    html += '         <label for="1Hinh"><i class="fa fa-camera w3-button w3-padding-large w3-text-teal" aria-hidden="true"></i></label>';
    html += '     </h3>';
    html += '</div>';
    $("#bar-hinh").append(html);
}

function refreshTapTin() {
    $("#countErrTapTin").val(0);
    $("#bar-taptin").empty();
    $("#errTapTin").remove();
    var html = '';
    html += '<div class="w3-margin-right w3-bar-item w3-border w3-border-gray w3-pale-blue w3-display-container">';
    html += '     <input type="file" hidden class="form-control validate" id="1TapTin" name="TapTin">';
    html += '     <h3>';
    html += '         <label for="1TapTin"><i class="fa fa-file w3-button w3-padding-large w3-text-teal" aria-hidden="true"></i></label>';
    html += '     </h3>';
    html += '</div>';
    $("#bar-taptin").append(html);
}

function closeModal() {
    $(".w3-modal").css("display", "none");
        
}
function openModal(curModal, nextModal) {
    refresh();
    $(curModal).css("display", "none");
    $(nextModal).css("display", "block");
}