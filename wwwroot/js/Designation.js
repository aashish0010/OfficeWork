

$("#dept").click(function () {
    $("#DesignationName").val(''); 
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
            "url": "Designation/Getdata",
            "type": "GET",
            "datatype": "json"
        },
        data: data,
        "columns": [ 
            { "data": "designationName" },
            
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
    if ($("#DesignationName").val() == '') {
        $("#error").show();
    }
    else {
        $.ajax({
            method: "POST",
            url: "Designation/Create",
            data: $("#Designation").serialize(),
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
                    url: "/Designation/Delete",
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
        url: "/Designation/Create",
        data: { id: id},
        success: function (data) {
            console.log(data);
            $('#DesignationName').val(data.designationName);
            $('#updateDate').val(data.updateDate);
            $('#addeddate').val(data.addedDate);
            $('#comId').val(data.comId);
            $('#customerId').val(data.customerId);

            
            $('#Id').val(data.id);
            
        }
    })

}
    

