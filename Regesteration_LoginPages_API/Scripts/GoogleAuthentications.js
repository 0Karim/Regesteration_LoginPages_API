/// <reference path="jquery-3.3.1.min.js" />




function getAccessToken() {
    if (location.hash) {
        if (location.hash.split('access_token=')) {
            var accessToken = location.hash.split('access_token=')[1].split('&')[0];
            if (accessToken) {
                isUserRegistered(accessToken);
            }
        }
    }
}


function isUserRegistered(accessToken) {
    $.ajax({
        url: '/api/Account/UserInfo',
        method: 'GET',
        headers: {
            'content-type': 'application/JSON',
            'Authorization': 'Bearer ' + accessToken
        },
        success: function (response) {
            if (response.HasRegistered) {
                //localStorage.setItem('accessToken', accessToken);
                //localStorage.setItem('username', response.Email);
                sessionStorage.setItem('accessToken', accessToken);
                sessionStorage.setItem('username', response.Email);
                window.location.href = "/RegisterView_LoginView_DataView_API/DataPage.html";
            }
            else {
                signupExternalUser(accessToken);
            }
        }
    });
}



function signupExternalUser(accessToken) {
    $.ajax({
        url: '/api/Account/RegisterExternal',
        method: 'POST',
        headers: {
            'content-type': 'application/json',
            'Authorization': 'Bearer ' + accessToken
        },
        success: function () {
            window.location.href = "/api/Account/ExternalLogin?provider=Google&response_type=token&client_id=self&redirect_uri=http%3A%2F%2Flocalhost%3A55835%2FRegisterView_LoginView_DataView_API%2FLogin.html&state=GerGr5JlYx4t_KpsK57GFSxVueteyBunu02xJTak5m01";
        }
    });

}
