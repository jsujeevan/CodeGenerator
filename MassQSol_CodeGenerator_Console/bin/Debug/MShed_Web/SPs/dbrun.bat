for %%G in (*.sql) do sqlcmd /S LOCALHOST /d MShed -E -i"%%G"
pause