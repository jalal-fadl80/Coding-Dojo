from django.shortcuts import render

def index(request):
    context = {
    'email': 'a@a.com',
    'name':'mike'
    }
    return render(request,'users/index.html', context)
