.class public final Le/d;
.super Ljava/lang/Object;
.source "SourceFile"

# interfaces
.implements Ljava/util/Iterator;


# instance fields
.field public final f:I

.field public g:I

.field public h:I

.field public i:Z

.field public final synthetic j:Le/h;


# direct methods
.method public constructor <init>(Le/h;I)V
    .locals 1

    iput-object p1, p0, Le/d;->j:Le/h;

    invoke-direct {p0}, Ljava/lang/Object;-><init>()V

    const/4 v0, 0x0

    iput-boolean v0, p0, Le/d;->i:Z

    iput p2, p0, Le/d;->f:I

    invoke-virtual {p1}, Le/h;->d()I

    move-result p1

    iput p1, p0, Le/d;->g:I

    return-void
.end method


# virtual methods
.method public final hasNext()Z
    .locals 2

    iget v0, p0, Le/d;->h:I

    iget v1, p0, Le/d;->g:I

    if-ge v0, v1, :cond_0

    const/4 v0, 0x1

    goto :goto_0

    :cond_0
    const/4 v0, 0x0

    :goto_0
    return v0
.end method

.method public final next()Ljava/lang/Object;
    .locals 3

    invoke-virtual {p0}, Le/d;->hasNext()Z

    move-result v0

    if-eqz v0, :cond_0

    iget v0, p0, Le/d;->h:I

    iget v1, p0, Le/d;->f:I

    iget-object v2, p0, Le/d;->j:Le/h;

    invoke-virtual {v2, v0, v1}, Le/h;->b(II)Ljava/lang/Object;

    move-result-object v0

    iget v1, p0, Le/d;->h:I

    const/4 v2, 0x1

    add-int/2addr v1, v2

    iput v1, p0, Le/d;->h:I

    iput-boolean v2, p0, Le/d;->i:Z

    return-object v0

    :cond_0
    new-instance v0, Ljava/util/NoSuchElementException;

    invoke-direct {v0}, Ljava/util/NoSuchElementException;-><init>()V

    throw v0
.end method

.method public final remove()V
    .locals 2

    iget-boolean v0, p0, Le/d;->i:Z

    if-eqz v0, :cond_0

    iget v0, p0, Le/d;->h:I

    add-int/lit8 v0, v0, -0x1

    iput v0, p0, Le/d;->h:I

    iget v1, p0, Le/d;->g:I

    add-int/lit8 v1, v1, -0x1

    iput v1, p0, Le/d;->g:I

    const/4 v1, 0x0

    iput-boolean v1, p0, Le/d;->i:Z

    iget-object v1, p0, Le/d;->j:Le/h;

    invoke-virtual {v1, v0}, Le/h;->f(I)V

    return-void

    :cond_0
    new-instance v0, Ljava/lang/IllegalStateException;

    invoke-direct {v0}, Ljava/lang/IllegalStateException;-><init>()V

    throw v0
.end method
