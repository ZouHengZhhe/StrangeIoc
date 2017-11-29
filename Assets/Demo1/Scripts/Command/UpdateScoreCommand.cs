using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using strange.extensions.command.impl;

public class UpdateScoreCommand:EventCommand
{
    [Inject]
    public ScoreModel scoreModel { get; set; }

    [Inject]
    public IScoreService scoreService { get; set; }

    public override void Execute()
    {
        scoreModel.Score++;
        scoreService.UpdateScore("http://xxx/xxx",scoreModel.Score);

        dispatcher.Dispatch(Demo1MediatorEvent.ScoreChange,scoreModel.Score);
    }
}
