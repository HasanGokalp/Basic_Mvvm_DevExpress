Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.Native

Public Class MainViewModel
    Inherits ViewModelBase

    'Commands
    Public Property GetAllCommand As ICommand
    'Props
    Public Property Cars As DXObservableCollection(Of Car)

    Public Sub New()
        GetAllCommand = New DelegateCommand(AddressOf GetAllCar)
    End Sub

    Public Sub GetAllCar()
        Cars = New CarService().GetAllCar
        RaisePropertiesChanged("Cars")
    End Sub
End Class
