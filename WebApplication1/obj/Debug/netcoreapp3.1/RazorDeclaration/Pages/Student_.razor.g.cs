// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServerApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\BlazorApps\BlazorServerApp\WebApplication1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\BlazorApps\BlazorServerApp\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\BlazorApps\BlazorServerApp\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\BlazorApps\BlazorServerApp\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\BlazorApps\BlazorServerApp\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\BlazorApps\BlazorServerApp\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\BlazorApps\BlazorServerApp\WebApplication1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\BlazorApps\BlazorServerApp\WebApplication1\_Imports.razor"
using BlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\BlazorApps\BlazorServerApp\WebApplication1\_Imports.razor"
using BlazorServerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\BlazorApps\BlazorServerApp\WebApplication1\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
using DataAccess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
using DataAccess.DTO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/students")]
    public partial class Student_ : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 253 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
      


    // very first load of table for students,,, displays number of rows
    // in table
    // @ref="table" code in table configuration
    private MudTable<Student> table;
    protected override Task OnAfterRenderAsync(bool firstRender)
    {
        table.SetRowsPerPage(5);
        return base.OnAfterRenderAsync(firstRender);
    }


    private bool hover = true;
    private HashSet<Student> selectedStudents = new HashSet<Student>();
    private Student selectedStudent = new Student();
    private HashSet<int> selectedIds = new HashSet<int>();

    private Student student = new Student();
    private List<Student> students = new List<Student>();
    public List<Transaction> transactions = new List<Transaction>();
    List<TransactionSummary> transactionSummary = new List<TransactionSummary>();


    // response from background-worker-process
    private BKProcessResponse BKP_Response_DB = new BKProcessResponse();
    private BKProcessResponse BKP_Response_CSVFile = new BKProcessResponse();

    // refresh-students
    // web-api call
    private async Task RefreshStudents()
    {
        students = await studentsApi.GetStudentsAsync();
    }

    // add students to csv file
    // call worker-process
    // via web-api call
    private async Task CallWorkerProcess_CSVFile()
    {
        BKP_Response_CSVFile = await studentsApi.AddStudentsToCSV_File_BackgroundWorkerProcessAsync();
    }

    // add students to db
    // call worker-process
    // via web-api call
    private async Task CallWorkerProcess_DB()
    {
        BKP_Response_DB = await studentsApi.AddStudentsToDB_BackgroundWorkerProcessAsync();
    }

    protected override async Task OnInitializedAsync()
    {
        // call to api-student-controller
        // this student-controller[api-worker-service-controller],,,
        // next uses student-service[data-access-service] to access database
        // comment line,,, await GetStudents();
        students = await studentsApi.GetStudentsAsync();


        // GetStudents();
        // await GetStudents();
    }

    // no need for this code
    // as blazor-app is calling api to get students
    private async Task<List<Student>> GetStudents()
    // private List<Student> GetStudents()
    {
        // students = studentService.GetStudents();
        students = await studentService.GetStudents();

        return students;
    }

    private Student GetStudent(int id)
    {
        student = studentService.GetStudent(id);

        return student;
    }
    private string HandleNull(string value)
    {
        if (value == null || value == "")
            return "N/A";
        else
            return value;
    }


    private void ClickEvent(Student model)
    {

        // transaction-summary for all selected-students
        selectedIds = new HashSet<int>();
        foreach (var s in selectedStudents)
        {
            selectedIds.Add(s.StudentId);
        }
        List<int> selectedIdsOfList = selectedIds.ToList();
        transactionSummary = studentService.GetTransactionsSummary(selectedIdsOfList);


        var flag = false;
        foreach (var sid in selectedIdsOfList)
        {
            if (sid == selectedStudent.StudentId)
            {
                flag = true;
                break;
            }
            else
            {
                flag = false;
            }
        }
        if (flag)
        {
            GetStudentTransactions(selectedStudent);
        }
        else
        {
            GetStudentTransactions(model);
        }
    }
    private List<Transaction> GetStudentTransactions(Student model)
    {
        if (model != null)
        {
            transactions = studentService.GetStudentTransactions(model.StudentId);
            return transactions;
        }
        else
        {
            transactions = new List<Transaction>();
            return new List<Transaction>();
        }
    }



    private string FormatRowStyle(Student selectedStudent, int index)
    {
        return "background-color:lightblue";
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MudBlazor.ISnackbar snackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataAccess.Contracts.IStudentService studentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorServerApp.ApiCallHelpers.StudentsApiClient studentsApi { get; set; }
    }
}
#pragma warning restore 1591
