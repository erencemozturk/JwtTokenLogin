# JwtTokenLogin
İlk önce POST olarak htpp://localhost:(yourhost)/api/Login url inin body kısmına 

JSON olarak
{ 
  "username":"erencem",
  "password":"admin1"
]
sendliyoruz bir token üretiyoruz ve token ı kopyalayıp  GET olarak htpp://localhost:(yourhost)/api/User/Admins url ine Authorization yaparak token ı tanımlıyoruz
