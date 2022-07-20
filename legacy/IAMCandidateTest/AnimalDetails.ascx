<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AnimalDetails.ascx.cs" Inherits="IAMCandidateTest.AnimalDetails" %>

<div class="row">
    <div class="col-sm-6">
        <table class="table table-condensed table-bordered">
            <tr>
                <th>Legs</th>
                <td><%: SelectedAnimal.LegCount > 0 ? SelectedAnimal.LegCount.ToString() : "(none)" %></td>
            </tr>
            <tr>
                <th>Wings</th>
                <td><%: SelectedAnimal.WingCount > 0 ? SelectedAnimal.WingCount.ToString() : "(none)" %></td>
            </tr>
            <tr>
                <th>Flight capable?</th>
                <td><%: SelectedAnimal.CanFly ? "Yes" : "No" %></td>
            </tr>
            <tr>
                <th>Taxonomy</th>
                <td>
                    <%: SelectedAnimal.TaxPhylum %><br />
                    <%: SelectedAnimal.TaxClass %><br />
                    <%: SelectedAnimal.TaxOrder %><br />
                    <%: SelectedAnimal.TaxFamily %><br />
                    <%: SelectedAnimal.TaxGenus %><br />
                    <%: SelectedAnimal.TaxSpecies %>
                </td>
            </tr>
        </table>
    </div>
</div>
