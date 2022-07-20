<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="VegetableDetails.ascx.cs" Inherits="IAMCandidateTest.VegetableDetails" %>

<div class="row">
    <div class="col-sm-6">
        <table class="table table-condensed table-bordered">
            <tr>
                <th>Edible Part:</th>
                <td><%: SelectedVegetable.EdiblePart %></td>
            </tr>
            <tr>
                <th>Vegetable is botanically classified as a fruit?</th>
                <td><%: SelectedVegetable.IsBotanicalFruit ? "Yes" : "No" %></td>
            </tr>
        </table>
    </div>
</div>