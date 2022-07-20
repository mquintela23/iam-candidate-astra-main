<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MineralDetails.ascx.cs" Inherits="IAMCandidateTest.MineralDetails" %>

<div class="row">
    <div class="col-sm-6">
        <table class="table table-condensed table-bordered">
            <tr>
                <th>Hardness</th>
                <td><%: SelectedMineral.Hardness %></td>
            </tr>
            <tr>
                <th>Luster</th>
                <td><%: SelectedMineral.Luster %></td>
            </tr>
            <tr>
                <th>Color</th>
                <td><%: SelectedMineral.Color %></td>
            </tr>
            <tr>
                <th>Streak</th>
                <td><%: SelectedMineral.Streak %></td>
            </tr>
            <tr>
                <th>Specific Gravity</th>
                <td><%: SelectedMineral.SpecificGravity %></td>
            </tr>
            <tr>
                <th>Diaphaneity</th>
                <td><%: SelectedMineral.Diaphaneity %></td>
            </tr>
        </table>
    </div>
</div>