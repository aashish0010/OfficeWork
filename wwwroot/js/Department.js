

$("#dept").click(function () {
    $("#DepartmentName").val(''); 
    $("#error").hide();
})


$(document).ready(function () {
    $("#data").DataTable({
        "processing": false,
        "serverSide": false,
        "filter": false,
        "deferRender": false,
        "paging": false,
        "ordering": false,
        "info": false,
        "ajax": {
            "url": "Department/Getdata",
            "type": "GET",
            "datatype": "json"
        },
        data: data,
        "columns": [ 
            { "data": "departmentName" },
            
            {
                data: "null", render: function (data, type, row, meta) {
                    return "<button class='btn btn-success'onclick=editFn(" + row.id + ")>Edit</button>" +
                        "<button class='btn btn-danger m-2' onclick=deleteFn(" + row.id + ")>Delete</button>"
                }
            }
            
        ]
    });
})

$("#savedata").on('click', function () {
    console.log("cicked");
    if ($("#DepartmentName").val() == '') {
        $("#error").show();
    }
    else {
        $.ajax({
            method: "POST",
            url: "Department/Create",
            data: $("#Department").serialize(),
            success: function (result) {
                $('#hide').click();
                $('#data').DataTable().ajax.reload();
            },
            error: function (err) {
                alert(err.responseText)
                console.log(err.responseText)
            }

        })

    }
    
});

function deleteFn(id) {
    console.log("here");
    swal({
        title: "Are you sure?",
        text: "Once deleted, you will not be able to recover this imaginary file!",
        icon: "warning",
        buttons: true,
        dangerMode: true,
    })
        .then((willDelete) => {        
                $.ajax({
                    method: "POST",
                    url: "/Department/Delete",
                    data: { id: id  },
                    success: function (data) {
                        console.log(data);
                        $('#data').DataTable().ajax.reload();
                    }
                })
            
        });
    
}

function editFn(id) {
    $('#dept').click();
    $.ajax({
        method: "GET",
        url: "/Department/Create",
        data: { id: id},
        success: function (data) {
            $('#DepartmentName').val(data.departmentName);
            $('#updateDate').val(data.updateDate);
            $('#createdDate').val(data.createdDate);
            $('#clientid').val(data.clientid);
            $('#companyid').val(data.companyid);
            $('#headid').val(data.headid);
            
            $('#Id').val(data.id);
            
        }
    })

}
    

